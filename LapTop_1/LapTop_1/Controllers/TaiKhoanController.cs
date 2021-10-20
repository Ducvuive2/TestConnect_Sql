using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using LapTop_1.Models;
using Volo.Abp.Data;

namespace LapTop_1.Controllers
{
    public class TaiKhoanController : Controller
    {
        private readonly IConfiguration configuration;

        public TaiKhoanController(IConfiguration config)
        {
            this.configuration = config;
        }
  
        public IActionResult Index()
        {

            string connStr = configuration.GetConnectionString("DefaultConnection");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            List<TaiKhoan> list = new List<TaiKhoan>();
            string query = "select * from _CODE_TAIKHOAN";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new TaiKhoan()
                        {
                            Tendangnhap = reader["TENDANGNHAP"].ToString(),
                            Matkhau = reader["MATKHAU"].ToString()
                        });

                    }

                }
            }
            return View(list);
        }
    }
}
