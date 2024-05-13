using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp2

{
    class Modify
    {
        
        public Modify() { }
        SqlDataAdapter DataAdapter;





        // khach hang //
        public DataTable GetDataTablekhachhang()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from KHACHHANG";
            using (SqlConnection sqlConnection = new SqlConnection(Connection.conn))
            {
                sqlConnection.Open();
                DataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }


            return dataTable;
        }

        public bool insertkhachhang(string id, string ten, string ngaysinh, string gioitinh, string cccd, string quoctich)
        {
            SqlConnection sqlConnection = new SqlConnection(Connection.conn);
            string query = "insert into KHACHHANG values (@id_KH , @ten , @ngaysinh , @gioitinh , @cmnd , @quoctich ) ";
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.Add("@id_KH", SqlDbType.NVarChar).Value = id;
                cmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.NVarChar).Value = ngaysinh;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = gioitinh;
                cmd.Parameters.Add("@cmnd", SqlDbType.NVarChar).Value = cccd;
                cmd.Parameters.Add("@quoctich", SqlDbType.NVarChar).Value = quoctich;
                cmd.ExecuteNonQuery();


            }
            catch{
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }


            return true;
        }

        public bool deletekhachhang(string id)
        {
            SqlConnection sqlConnection = new SqlConnection(Connection.conn);
            string query = "delete from KHACHHANG WHERE id_KH = @id_KH";
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.Add("@id_KH", SqlDbType.NVarChar).Value = id;
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }


            return true;
        }

        public bool updatekhachhang(string id, string ten, string ngaysinh, string gioitinh, string cccd, string quoctich)
        {
            SqlConnection sqlConnection = new SqlConnection(Connection.conn);
            string query = "UPDATE KHACHHANG set ten = @ten ,ngaysinh=  @ngaysinh ,gioitinh = @gioitinh , cmnd = @cmnd , quoctich =@quoctich where id_KH = @id_KH ;";
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.Add("@id_KH", SqlDbType.NVarChar).Value = id;
                cmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.NVarChar).Value = ngaysinh;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = gioitinh;
                cmd.Parameters.Add("@cmnd", SqlDbType.NVarChar).Value = cccd;
                cmd.Parameters.Add("@quoctich", SqlDbType.NVarChar).Value = quoctich;
                cmd.ExecuteNonQuery();


            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }


            return true;
        }




        // Phong
        public DataTable GetDataTablePhong()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT PHONG.id_P , PHONG.ten_P , PHONG.ten_LP, PHONG.tinhtrang ,  LOAIPHONG.succhua,LOAIPHONG.giaphong FROM PHONG , LOAIPHONG Where PHONG.ten_LP = LOAIPHONG.ten_LP ";
            using (SqlConnection sqlConnection = new SqlConnection(Connection.conn))
            {
                sqlConnection.Open();
                DataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataAdapter.Fill(dataTable);

              // string srt = dataTable.Rows[1][0].ToString();
                sqlConnection.Close();
            }


            return dataTable;
        }

        public bool insertphong(string id, string ten, string tinhtrang, string ten_lp)
        {
            SqlConnection sqlConnection = new SqlConnection(Connection.conn);
            string query = "insert into PHONG values (@id_P , @ten_P , @tinhtrang , @ten_LP ) ";
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.Add("@id_P", SqlDbType.NVarChar).Value = id;
                cmd.Parameters.Add("@ten_P", SqlDbType.NVarChar).Value = ten;
                cmd.Parameters.Add("@tinhtrang", SqlDbType.NVarChar).Value = tinhtrang;
                cmd.Parameters.Add("@ten_LP", SqlDbType.NVarChar).Value = ten_lp;
    
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }


            return true;
        }

        public bool deletePhong(string id)
        {
            SqlConnection sqlConnection = new SqlConnection(Connection.conn);
            string query = "delete from PHONG WHERE id_P = @id_P";
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.Add("@id_P", SqlDbType.NVarChar).Value = id;
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }


            return true;
        }

        public bool updatephong(string id, string ten, string tinhtrang, string ten_lp)
        {
            SqlConnection sqlConnection = new SqlConnection(Connection.conn);
            string query = "update phong set ten_P = @ten_P , tinhtrang = @tinhtrang , ten_LP = @ten_LP where id_P = @id_P";
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.Add("@id_P", SqlDbType.NVarChar).Value = id;
                cmd.Parameters.Add("@ten_P", SqlDbType.NVarChar).Value = ten;
                cmd.Parameters.Add("@tinhtrang", SqlDbType.NVarChar).Value = tinhtrang;
                cmd.Parameters.Add("@ten_LP", SqlDbType.NVarChar).Value = ten_lp;
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }


            return true;
        }

        // dich vu
        public DataTable GetDataTableDichVu()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from DICHVU";
            using (SqlConnection sqlConnection = new SqlConnection(Connection.conn))
            {
                sqlConnection.Open();
                DataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }


            return dataTable;
        }
        public bool insertdichvu(string id, string ten, string gia)
        {
            SqlConnection sqlConnection = new SqlConnection(Connection.conn);
            string query = "insert into DICHVU values (@id_DV , @ten_DV , @gia_DV) ";
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.Add("@id_DV", SqlDbType.NVarChar).Value = id;
                cmd.Parameters.Add("@ten_DV", SqlDbType.NVarChar).Value = ten;
                cmd.Parameters.Add("@gia_DV", SqlDbType.NVarChar).Value = gia;
                cmd.ExecuteNonQuery();


            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }


            return true;
        }


        public bool deleteDichVu(string id)
        {
            SqlConnection sqlConnection = new SqlConnection(Connection.conn);
            string query = "delete from DICHVU WHERE id_DV = @id_DV";
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.Add("@id_DV", SqlDbType.NVarChar).Value = id;
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }


            return true;
        }


        public bool updatedichvu(string id, string ten, string gia)
        {
            SqlConnection sqlConnection = new SqlConnection(Connection.conn);
            string query = "update DICHVU set ten_DV = @ten_DV , gia_DV=@gia_DV where id_DV = @id_DV ";
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.Add("@id_DV", SqlDbType.NVarChar).Value = id;
                cmd.Parameters.Add("@ten_DV", SqlDbType.NVarChar).Value = ten;
                cmd.Parameters.Add("@gia_DV", SqlDbType.NVarChar).Value = gia;
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }


            return true;
        }
        public DataTable GetDataTableDatPhong()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT PHONG.id_P as N'Mã phòng', PHONG.ten_P as N'Tên phòng', PHONG.ten_LP as N'Loại phòng', PHONG.tinhtrang as N'tình trạng',  LOAIPHONG.succhua as N'Sức chứa',LOAIPHONG.giaphong as N'Giá phòng'FROM PHONG , LOAIPHONG Where PHONG.ten_LP = LOAIPHONG.ten_LP   and tinhtrang = N'Sẵn sàng'";
            using (SqlConnection sqlConnection = new SqlConnection(Connection.conn))
            {
                sqlConnection.Open();
                DataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }



        public DataTable GetDataTableTraPhong()
        {
            string makh = fkhackhang.id_kh;
            DataTable dataTable = new DataTable();
            string query = "select * from HOADON where HOADON.ngaytra is null and id_KH='"+makh+"'";
            using (SqlConnection sqlConnection = new SqlConnection(Connection.conn))
            {
                sqlConnection.Open();
                DataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public DataTable GetDataTableHoadon()
        {
            DataTable dataTable = new DataTable();
            string query = " select HOADON.id_HD as N'Mã hóa đơn' , KHACHHANG.ten as N'Tên khách hàng', KHACHHANG.ngaysinh as N'Ngày sinh' ,KHACHHANG.gioitinh as N'Giới tính', PHONG.ten_P as N'tên Phòng' , LOAIPHONG.ten_LP N'Loại phòng' , LOAIPHONG.giaphong N'Giá Phòng' ,  DATEDIFF(DAY,HOADON.ngayvao,HOADON.ngaytra) as N'số ngày ở ' , SUM(DATEDIFF(DAY,HOADON.ngayvao,HOADON.ngaytra)*LOAIPHONG.giaphong) as N'Tổng'  from KHACHHANG , HOADON , PHONG , LOAIPHONG where KHACHHANG.id_KH = HOADON.id_KH and HOADON.id_P = PHONG.id_P and PHONG.ten_LP = LOAIPHONG.ten_LP  and HOADON.tinhtrang = '1' group by HOADON.id_HD , KHACHHANG.ten , KHACHHANG.ngaysinh ,KHACHHANG.gioitinh , PHONG.ten_P , LOAIPHONG.ten_LP , LOAIPHONG.giaphong ,  DATEDIFF(DAY, HOADON.ngayvao, HOADON.ngaytra)";
            using (SqlConnection sqlConnection = new SqlConnection(Connection.conn))
            {
                sqlConnection.Open();
                DataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public DataTable GetDataTableHoaDonDichVu(string id_HD)
        {
            DataTable dataTable = new DataTable();
            string query = " select CHITIETHOADON.id_DV as N'Mã dịch vụ', DICHVU.ten_DV as N'Tên dịch vụ', CHITIETHOADON.soluong as N'Số lượng', CHITIETHOADON.ngaysudung N'Ngày sử dụng', sum(CHITIETHOADON.soluong*DICHVU.gia_DV) as N'Tổng' from HOADON , CHITIETHOADON , DICHVU where HOADON.id_HD = CHITIETHOADON.id_HD and CHITIETHOADON.id_DV = DICHVU.id_DV and HOADON.id_HD = '" + id_HD + "' group by CHITIETHOADON.id_DV , CHITIETHOADON.soluong , CHITIETHOADON.ngaysudung  , DICHVU.ten_DV";
            using (SqlConnection sqlConnection = new SqlConnection(Connection.conn))
            {
                sqlConnection.Open();
                DataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public DataTable GetDataTableHoaDonphong(string id_HD)
        {
            DataTable dataTable = new DataTable();
            string query = " select HOADON.id_HD as N'Mã hóa đơn', HOADON.id_P as N'Mã Phòng' ,LOAIPHONG.ten_LP as N'Loại phòng', LOAIPHONG.giaphong as N'Giá phòng', DATEDIFF(DAY,HOADON.ngayvao,HOADON.ngaytra) as N'số ngày ở ' , SUM(DATEDIFF(DAY,HOADON.ngayvao,HOADON.ngaytra)*LOAIPHONG.giaphong) as N'Tổng' from PHONG ,LOAIPHONG,HOADON where PHONG.ten_LP = LOAIPHONG.ten_LP and PHONG.id_P = HOADON.id_P and HOADON.id_HD = '"+id_HD + "' group by LOAIPHONG.ten_LP ,HOADON.id_HD , HOADON.id_KH , HOADON.id_P , LOAIPHONG.giaphong , DATEDIFF(DAY,HOADON.ngayvao,HOADON.ngaytra)";
            using (SqlConnection sqlConnection = new SqlConnection(Connection.conn))
            {
                sqlConnection.Open();
                DataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }


        public DataTable GetDataTableThongke(string tu , string den)
        {
            DataTable dataTable = new DataTable();
            string query = "select HOADON.id_HD as N'Mã hóa đơn' , KHACHHANG.ten as N'Tên khách hàng' , KHACHHANG.ngaysinh as N'ngày sinh',KHACHHANG.gioitinh as N'giới tính', PHONG.ten_P as N' Tên phòng', LOAIPHONG.ten_LP as N'Loại phòng', LOAIPHONG.giaphong as N'Giá phòng',  DATEDIFF(DAY,HOADON.ngayvao,HOADON.ngaytra) as N'số ngày ở ' , SUM(DATEDIFF(DAY,HOADON.ngayvao,HOADON.ngaytra)*LOAIPHONG.giaphong) as N'Tổng'  from KHACHHANG , HOADON , PHONG , LOAIPHONG where KHACHHANG.id_KH = HOADON.id_KH and HOADON.id_P = PHONG.id_P and PHONG.ten_LP = LOAIPHONG.ten_LP  and HOADON.tinhtrang = '1' and HOADON.ngaytra between '"+tu+"' and '"+ den +"' group by HOADON.id_HD , KHACHHANG.ten , KHACHHANG.ngaysinh ,KHACHHANG.gioitinh , PHONG.ten_P , LOAIPHONG.ten_LP , LOAIPHONG.giaphong ,  DATEDIFF(DAY, HOADON.ngayvao, HOADON.ngaytra)";
            using (SqlConnection sqlConnection = new SqlConnection(Connection.conn))
            {
                sqlConnection.Open();
                DataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
    }
}