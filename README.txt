Do là sản phẩm local nên khi muốn run được code vui lòng làm theo các bước sau:
- Bước 1: Mở phần mềm Microsoft SQL Server Management Studio. Lưu ý Run as administrator.
- Bước 2: Khi Dialog đầu tiên yêu cầu Connect to Server, vui lòng copy tên Server của máy bạn lại. Ví dụ: Server name: .\SQLEXPRESS.
- Bước 3: Mở file OFFICIAL SQL trong phần mềm này bằng cách nhấn tổ hợp Ctrl + O và chọn file.
- Bước 4: Sau khi mở tiếp tục nhấn F5 hoặc click nút Excute trong phần mềm.
- Bước 5: Run file YameStore.sln để chạy file bằng phần mềm Microsoft Visual Studio.
- Bước 6: Sau khi load xong vui lòng mở Solution Explorer bằng cách nhấn tổ hợp phím Ctrl + Alt + L và mở file App.config lên.
- Bước 7: Paste tên Server mà bạn vừa copy khi nảy vào Data Source=

<add name="DbConnection" connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=YAME;Integrated Security=True" providerName="System.Data.SqlClient" />

- Bước 8: Khi làm đúng 7 bước trên bạn đã có thể Run Project của chúng tôi.

Lưu ý: chương trình được thực hiện bằng .net6.