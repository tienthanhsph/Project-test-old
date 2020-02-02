using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DMCWeb.Models;
namespace DMCWeb.Logic
{
    public class TuDienNhaO
    {
        DMCWebEntities db = new DMCWebEntities();
        public bool ThemNhaO(string TenLoaiNha)
        {
           try{
                tblLoaiNhaO_CongTrinh loainhamoi = new tblLoaiNhaO_CongTrinh();
                loainhamoi.Ten = TenLoaiNha;
                db.tblLoaiNhaO_CongTrinh.Add(loainhamoi);
                db.SaveChanges();
               return true;
           }
           catch(Exception ex)
           {
                return false;
           }
        }
        public bool XoaNhaO(int ID)
        {
            try
            {
                tblLoaiNhaO_CongTrinh nhacanxoa = (from n in db.tblLoaiNhaO_CongTrinh
                                                    select n).Single(n => n.LoaiNhaO == ID);
                db.tblLoaiNhaO_CongTrinh.Remove(nhacanxoa);
                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public bool SuaTenNha(int ID, string TenMoi)
        {
            try
            {
                tblLoaiNhaO_CongTrinh nhacansua = (from n in db.tblLoaiNhaO_CongTrinh
                                                  select n).Single(n=> n.LoaiNhaO == ID);
                nhacansua.Ten = TenMoi;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public List<tblLoaiNhaO_CongTrinh> DSLoaiNhaO()
        {
            try
            {
                var DS = from n in db.tblLoaiNhaO_CongTrinh
                                                 select n;
                return DS.ToList<tblLoaiNhaO_CongTrinh>();
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}