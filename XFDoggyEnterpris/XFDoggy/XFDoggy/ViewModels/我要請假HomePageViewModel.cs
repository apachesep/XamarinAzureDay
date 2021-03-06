﻿using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using Prism.Events;
using XFDoggy.Repositories;
using XFDoggy.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace XFDoggy.ViewModels
{
    public class 我要請假HomePageViewModel : BindableBase, INavigationAware
    {

        #region Repositories (遠端或本地資料存取)
        請假紀錄Repository foo請假紀錄Repository = new 請假紀錄Repository();
        #endregion

        #region ViewModel Property (用於在 View 中作為綁定之用)
        #region 請假紀錄項目清單
        private ObservableCollection<請假紀錄項目ViewModel> _請假紀錄項目清單 = new ObservableCollection<請假紀錄項目ViewModel>();
        /// <summary>
        /// 請假紀錄項目清單
        /// </summary>
        public ObservableCollection<請假紀錄項目ViewModel> 請假紀錄項目清單
        {
            get { return _請假紀錄項目清單; }
            set { SetProperty(ref _請假紀錄項目清單, value); }
        }
        #endregion

        #region 點選請假紀錄項目
        private 請假紀錄項目ViewModel _點選請假紀錄項目;
        /// <summary>
        /// 點選請假紀錄項目
        /// </summary>
        public 請假紀錄項目ViewModel 點選請假紀錄項目
        {
            get { return this._點選請假紀錄項目; }
            set { this.SetProperty(ref this._點選請假紀錄項目, value); }
        }
        #endregion

        #endregion

        #region Field 欄位

        public DelegateCommand 點選請假紀錄項目Command { get; set; }
        public DelegateCommand 點選新增請假紀錄項目Command { get; set; }


        private readonly INavigationService _navigationService;
        private readonly IEventAggregator _eventAggregator;
        #endregion

        #region Constructor 建構式
        public 我要請假HomePageViewModel(INavigationService navigationService, IEventAggregator eventAggregator)
        {

            #region 相依性服務注入的物件

            _eventAggregator = eventAggregator;
            _navigationService = navigationService;
            #endregion

            #region 頁面中綁定的命令
            點選請假紀錄項目Command = new DelegateCommand(async () =>
            {
                var fooID = 點選請假紀錄項目.ID;
                點選請假紀錄項目 = null;
                await _navigationService.NavigateAsync($"我要請假記錄修改Page?ID={fooID}");
            });
            點選新增請假紀錄項目Command = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync($"我要請假記錄修改Page");
            });
            #endregion
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public async void OnNavigatedTo(NavigationParameters parameters)
        {
            await Init();
        }
        #endregion

        #region Navigation Events (頁面導航事件)
        #endregion

        #region 設計時期或者執行時期的ViewModel初始化
        #endregion

        #region 相關事件
        #endregion

        #region 相關的Command定義
        #endregion

        #region 其他方法
        /// <summary>
        /// 進行要顯示資料的初始化
        /// </summary>
        private async Task Init()
        {
            // 讀取 Repository 資料
            await foo請假紀錄Repository.Read();

            請假紀錄項目清單.Clear();
            foreach (var item in foo請假紀錄Repository.請假紀錄)
            {
                請假紀錄項目清單.Add(new 請假紀錄項目ViewModel
                {
                    ID = item.ID,
                    假別 = item.假別,
                    申請人 = item.申請人,
                    職務代理人 = item.職務代理人,
                    請假日期 = item.請假日期,
                    請假時數 = item.請假時數,
                    請假理由 = item.請假理由,
                    開始時間 = item.開始時間,
                });
            }
        }
        #endregion
    }
}
