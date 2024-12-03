using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Dashboard.DAO
{
    public class DataProvider
    {
        private static string ServerName = "(local)"; //Đổi tên lại theo Server Name của SQL 
 
        private static string DatabaseName = "QuanLyCafe"; //Tên database
        private string ConnStr = $@"Data Source={ServerName}; Initial Catalog={DatabaseName};Integrated Security=True";
        private static DataProvider instance;

        private DataProvider() { }

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        //Hàm thực thi câu lệnh sqlCommand, giá trị trả về là 1 bảng giá trị
        public DataTable ExecuteQuery(string query, object[] paramenter = null)
        {
            DataTable data = new DataTable(); //Khai báo biến data là 1 bảng dữ liệu
            using (SqlConnection conn = new SqlConnection(ConnStr)) //đảm bảo rằng đối tượng SqlConnection được giải phóng tự động sau khi sử dụng, mà không cần phải gọi phương thức Dispose() của đối tượng
            {
                conn.Open(); //Mở kết nối
                SqlCommand cmd = new SqlCommand(query, conn); //Thực hiện truy vấn
                if (paramenter != null) //Nếu không có tham số nào truyền vào
                {
                    string[] listPara = query.Split(' '); //Thực hiện tách chuỗi để tách phần tên của tham số cần truyền giá trị
                    int i = 0; //Khai báo biến đếm, biến này lưu trữ giá trị trong object[] paramenter
                    foreach (string item in listPara) //Bắt đầu duyệt qua từng phần tử
                    {
                        if (item.Contains('@')) //Nếu tìm thấy giá trị có chứa "@" tức mở đầu của khai báo paramenter
                        {
                            if (paramenter[i] != null) //Nếu phần tử paramenter đang duyệt không rỗng
                            {
                                SqlParameter parameter = new SqlParameter(item, paramenter[i]); // Khai báo paramenter và sẽ nhận giá trị truyền vào
                                cmd.Parameters.Add(parameter); //Gán paramenter vào
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue(item, DBNull.Value); //Còn không thì set giá trị default của paramenter
                            }
                            i++;
                        }
                    }
                }

                /* GIẢI THÍCH ĐOẠN CODE PHÍA TRÊN: Đoạn mã trên là một điều kiện IF trong ngôn ngữ lập trình C#. Nó kiểm tra xem giá trị của biến "parameter" có khác NULL hay không. Nếu khác NULL, nó sẽ thực hiện các câu lệnh trong phần thân của IF.
                Phần thân của IF bắt đầu bằng việc tách câu truy vấn "query" thành một danh sách các chuỗi bằng cách sử dụng phương thức Split() và chia nhỏ chuỗi thành các phần tử của một mảng. Việc chia nhỏ được thực hiện bằng cách tách các chuỗi theo khoảng trắng ' '.
                Sau khi có danh sách các chuỗi, vòng lặp foreach được sử dụng để duyệt qua từng phần tử trong danh sách. Nếu phần tử đó chứa ký tự '@', nó được coi là một tham số và thêm giá trị của tham số này vào trong đối tượng SqlCommand cmd bằng cách sử dụng phương thức AddWithValue(). Tham số này được lấy từ mảng "parameter" bằng cách sử dụng biến "i" như một chỉ mục để lấy giá trị tương ứng.
                Đoạn mã này thường được sử dụng để thêm các tham số vào câu truy vấn SQL để tránh các lỗ hổng bảo mật, cũng như đảm bảo tính nhất quán và độ tin cậy của câu truy vấn.*/
                //LƯU Ý: Đối với Procedure và Function thì Khi gọi string query để truyền vào tham số thì cần chú ý phải nhập theo
                //đúng định dạng EXECUTE/SELECT [Name] @para1 , @para2 , ... dấu phẩy giữa 2 tham số phải cách ký tự phía
                //trước và phía sau 1 ký tự khoảng trắng ví dụ:
                // EXECUTE GetInfo @id , @name

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data); //Lấy dữ liệu từ một nguồn dữ liệu và đổ dữ liệu này vào một đối tượng data.

                conn.Close(); //Đóng kết nối
            }
            return data; //Trả về giá trị data
        }

        //Hàm trả về giá trị số cột
        public int ExecuteNonQuery(string query, object[] paramenter = null)
        {
            int data = 0;
            using (SqlConnection conn = new SqlConnection(ConnStr)) //đảm bảo rằng đối tượng SqlConnection được giải phóng tự động sau khi sử dụng, mà không cần phải gọi phương thức Dispose() của đối tượng
            {
                conn.Open(); //Mở kết nối
                SqlCommand cmd = new SqlCommand(query, conn); //Thực hiện truy vấn
                if (paramenter != null) //Nếu không có tham số nào truyền vào
                {
                    string[] listPara = query.Split(' '); //Thực hiện tách chuỗi để tách phần tên của tham số cần truyền giá trị
                    int i = 0; //Khai báo biến đếm, biến này lưu trữ giá trị trong object[] paramenter
                    foreach (string item in listPara) //Bắt đầu duyệt qua từng phần tử
                    {
                        if (item.Contains('@')) //Nếu tìm thấy giá trị có chứa "@" tức mở đầu của khai báo paramenter
                        {
                            if (paramenter[i] != null) //Nếu phần tử paramenter đang duyệt không rỗng
                            {
                                SqlParameter parameter = new SqlParameter(item, paramenter[i]); // Khai báo paramenter và sẽ nhận giá trị truyền vào
                                cmd.Parameters.Add(parameter); //Gán paramenter vào
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue(item, DBNull.Value); //Còn không thì set giá trị default của paramenter
                            }
                            i++;
                        }
                    }
                }

                data = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return data;
        }

        //Thực thi query trả về giá trị đầu tiên của kết quả
        public object ExecuteScalar(string query, object[] paramenter = null)
        {
            object data = 0;
            using (SqlConnection conn = new SqlConnection(ConnStr)) //đảm bảo rằng đối tượng SqlConnection được giải phóng tự động sau khi sử dụng, mà không cần phải gọi phương thức Dispose() của đối tượng
            {
                conn.Open(); //Mở kết nối
                SqlCommand cmd = new SqlCommand(query, conn); //Thực hiện truy vấn
                if (paramenter != null) //Nếu không có tham số nào truyền vào
                {
                    string[] listPara = query.Split(' '); //Thực hiện tách chuỗi để tách phần tên của tham số cần truyền giá trị
                    int i = 0; //Khai báo biến đếm, biến này lưu trữ giá trị trong object[] paramenter
                    foreach (string item in listPara) //Bắt đầu duyệt qua từng phần tử
                    {
                        if (item.Contains('@')) //Nếu tìm thấy giá trị có chứa "@" tức mở đầu của khai báo paramenter
                        {
                            if (paramenter[i] != null) //Nếu phần tử paramenter đang duyệt không rỗng
                            {
                                SqlParameter parameter = new SqlParameter(item, paramenter[i]); // Khai báo paramenter và sẽ nhận giá trị truyền vào
                                cmd.Parameters.Add(parameter); //Gán paramenter vào
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue(item, DBNull.Value); //Còn không thì set giá trị default của paramenter
                            }
                            i++;
                        }
                    }
                }
                object scalarResult = cmd.ExecuteScalar();
                if (scalarResult != DBNull.Value)
                {
                    data = scalarResult;
                }
                conn.Close();
            }
            return data;
        }

    }
}
