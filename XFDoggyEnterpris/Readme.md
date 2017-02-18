# 摘要說明

Xamarin.Forms 跨平台應用程式開發工具非常適合開發企業內部的行動應用專案上，這個應用程式使用 Xamarin.Froms 工具來進行開發並且可以在 Android / iOS / UWP 三個平台下執行；有鑑於要使用 Xamarin.Forms 開發出一套跨平台的應用程式，將會有許多需要了解與處理的地方，因此，特別設計這個應用程式，讓您可以參考這個應用程式的設計方法與架構，便可快速地使用 Xamarin.Forms 工具，開發出適合您的企業內部應用程式。

這個範例應用程式模擬企業內部常用的七項功能，每個功能都會有著不同需求的設計技巧：

導航抽屜

* 將公司 Logo 放置在導航面板的最上方

* 應用程式各大主要功能使用 Font Awesome 字體來標示

* 所執行的功能項目文字，將會高亮顯示

* 導航工具列顏色有客製化

關於

* 展示如何將企業內部網頁崁入到跨平台行動應用程式中

* 使用下拉選單，來切換不同網站

差旅費用申請

* 這是個一對多的資料處理功能

* 清單中的每筆紀錄，會以兩行的方式來顯示

* 新增功能按鈕，將會以浮動方式呈現在螢幕右下方

* 記錄明細欄位，將會以兩行的方式來呈現

* 新增與修改模式，會有儲存與刪除操作按鈕顯示在輸入資料最下方

* 不管有無輸入資料，都可以使用軟體或者硬體回上一頁按鈕

* 儲存不會做資料驗證檢查

* 刪除將會請使用者再度做確認

* 資料異動將不會永久儲存

我要請假

* 這是個一對多的資料處理功能

* 清單中的每筆紀錄，會以左邊圖示與右邊兩行文字的方式來顯示

* 新增功能按鈕，將會以導航工具列按鈕出現在螢幕右上方

* 記錄明細欄位，將會以一行的方式來呈現

* 新增與修改模式，儲存與取消按鈕將會使用導航工具列來呈現，並且，取消按鈕預設為隱藏，刪除按鈕鎖定顯示在螢幕最下方(新增模式下，這個按鈕將不會出現)

* 軟體或者硬體回上一頁按鈕，在明細紀錄維護的時候，將無法使用

* 儲存會做資料驗證檢查

* 取消或刪除將會請使用者再度做確認

* 資料異動將會永久儲存

填寫工作日報表

* 這是個一對多的資料處理功能

* 清單中的每筆紀錄，會以左邊面板與右邊兩行文字的方式來顯示；左邊面板可以看到這天的所有工作時數統計，若同一天有多筆資料，則左邊的面板只會出現一次。

* 新增功能按鈕，將會以導航工具列按鈕出現在螢幕右上方

* 記錄明細欄位，將會以一行的方式來呈現

* 新增與修改模式，儲存與取消按鈕將會使用導航工具列來呈現，刪除按鈕鎖定顯示在螢幕最下方(在新增模式下，刪除按鈕將會無法作用)

* 軟體或者硬體回上一頁按鈕，在明細紀錄維護的時候，將無法使用

* 儲存會做資料驗證檢查

* 取消或刪除將會請使用者再度做確認

* 資料異動將會永久儲存

* 如何在 ListView 的每筆紀錄內，綁定 ViewModel 內的 Command

* 應用 canExecuteMethod 動態啟用或停用命令

最新消息

* 只有清單資料會顯示

* 模擬從網路讀取資料(需要些時間)，因此，會有忙碌中的遮罩

* 具有下滑手勢資料更新操作

* 具有動態讀取更多資料的功能(當最後一筆紀錄出現在螢幕上)

* 每筆紀錄可以長按，使用彈出選單來操作

On-Call電話

* 只有清單資料會顯示

* 點選清單中的不同位置電話號碼，可立即撥號

* 如何在 ListView 的每筆紀錄內，綁定 ViewModel 內的 Command