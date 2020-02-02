using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ExePgnFile
{
    public class QuanCo
    {
        public BanCo banco { get; set; }
        public int _flag { get; set; }
        public string _color{ get; set;}         
        public string Name { get; set; }
        public bool _live { get; set; }
        public string _Image { get; set; }
        public Size _size { get; set; }
        public int _GiaTri { get; set; }
        public ViTri _vitri { get; set; }
        public List<ViTri> CacNuocDi = new List<ViTri>();
        //public virtual void Di() { }
        //public virtual void An() { }
        public virtual void TimCacNuocDi() { }       
    }
    public struct ViTri
    {
        public int x;
        public int y;
        
        public ViTri(int x, int y)
        {

            this.x = x;
            this.y = y;
        }
    }


    enum LoaiQuan {Tuong, Hau, Xe, Tinh, Ma , Tot};
    enum KyHieuQuan {K,Q,R,B,N,P};

    public class King: QuanCo
    {
        public King()
        {
            _live = true;
            _GiaTri = 1000;
            
        }
       
        public override void TimCacNuocDi()
        {
            int _x = this._vitri.x;
            int _y = this._vitri.y;
            CacNuocDi.Clear();
            for (int i = _x - 1; i < _x + 2; i++)
            {
                for (int j = _y - 1; j < _y + 2; j++)
                {
                    if ((Math.Abs(i - _x) + Math.Abs(j - _y) == 1) && i >= 0 && i<8 && j >=0 && j<8)
                    {
                        ViTri vt = new ViTri(i, j);
                        CacNuocDi.Add(vt);
                    }
                }
            }

            // bỏ những nước đi không hợp lệ...
            List<ViTri> CacNuocDiCanLoaiRa = new List<ViTri>();
            ViTri[] CacNuocDi_arr = new ViTri[CacNuocDi.Count];
            CacNuocDi.CopyTo(CacNuocDi_arr);
            for (int i = 0; i < CacNuocDi_arr.Length; i++)
            {
                int vtx = CacNuocDi_arr[i].x;
                int vty = CacNuocDi_arr[i].y;
                if (banco.Table[vtx, vty] == _flag)
                {
                    CacNuocDi.Remove(CacNuocDi_arr[i]);
                }
            }
            
        }
    }
    public class Queen : QuanCo
    {
        public Queen()
        {
            _live = true;
            _GiaTri = 9;
            
        
        }
        public override void TimCacNuocDi()
        {
            int _x = this._vitri.x;
            int _y = this._vitri.y;
            CacNuocDi.Clear();
           // Tìm theo cách của Xe
            int k = 0;
            for (int i = _x+1; i < 8; i++)
            {
                if (banco.Table[i, _y] == _flag)
                    break;
                else
                {
                    if (banco.Table[i, _y] == 0)
                    {
                        ViTri vt = new ViTri(i, _y);
                        CacNuocDi.Add(vt);
                    }
                    else
                    {
                        if (k == 0)
                        {
                            ViTri vt = new ViTri(i, _y);
                            CacNuocDi.Add(vt);
                            k++;
                        }
                        else
                            break;
                        
                    }
                }
            }
            k = 0;

            for (int i = _x - 1; i >= 0; i--)
            {
                if (banco.Table[i, _y] == _flag)
                    break;
                else
                {
                    if (banco.Table[i, _y] == 0)
                    {
                        ViTri vt = new ViTri(i, _y);
                        CacNuocDi.Add(vt);
                    }
                    else
                    {
                        if (k == 0)
                        {
                            ViTri vt = new ViTri(i, _y);
                            CacNuocDi.Add(vt);
                            k++;
                        }
                        else
                            break;

                    }
                }
            }
            k = 0;

            for (int j = _y + 1; j < 8; j++)
            {
                if (banco.Table[_x,j] == _flag)
                    break;
                else
                {
                    if (banco.Table[_x, j] == 0)
                    {
                        ViTri vt = new ViTri(_x, j);
                        CacNuocDi.Add(vt);
                    }
                    else
                    {
                        if (k == 0)
                        {
                            ViTri vt = new ViTri(_x, j);
                            CacNuocDi.Add(vt);
                            k++;
                        }
                        else
                            break;

                    }
                }
            }
            k = 0;
            for (int j = _y - 1; j >=0; j--)
            {
                if (banco.Table[_x, j] == _flag)
                    break;
                else
                {
                    if (banco.Table[_x, j] == 0)
                    {
                        ViTri vt = new ViTri(_x, j);
                        CacNuocDi.Add(vt);
                    }
                    else
                    {
                        if (k == 0)
                        {
                            ViTri vt = new ViTri(_x, j);
                            CacNuocDi.Add(vt);
                            k++;
                        }
                        else
                            break;

                    }
                }
            }
           

            // Tìm theo cách của Tịnh
            k = 0;
            for (int i = _x + 1; i < 8; i++)
            {
                k = 0;
                for (int j = _y + 1; j < 8; j++)
                {
                    if (banco.Table[j, j] == _flag)
                        break;
                    else
                    {
                        if (banco.Table[j, j] == 0)
                        {
                            ViTri vt = new ViTri(j, j);
                            CacNuocDi.Add(vt);
                        }
                        else
                        {
                            if (k == 0)
                            {
                                ViTri vt = new ViTri(j, j);
                                CacNuocDi.Add(vt);
                                k++;
                            }
                            else
                                break;

                        }
                    }
                }
                k = 0;
                for (int j = _y - 1; j >= 0; j--)
                {
                    if (banco.Table[j, j] == _flag)
                        break;
                    else
                    {
                        if (banco.Table[j, j] == 0)
                        {
                            ViTri vt = new ViTri(j, j);
                            CacNuocDi.Add(vt);
                        }
                        else
                        {
                            if (k == 0)
                            {
                                ViTri vt = new ViTri(j, j);
                                CacNuocDi.Add(vt);
                                k++;
                            }
                            else
                                break;

                        }
                    }
                }
            }
            for (int i = _x - 1; i >= 0; i--)
            {
                k = 0;
                for (int j = _y + 1; j < 8; j++)
                {
                    if (banco.Table[j, j] == _flag)
                        break;
                    else
                    {
                        if (banco.Table[j, j] == 0)
                        {
                            ViTri vt = new ViTri(j, j);
                            CacNuocDi.Add(vt);
                        }
                        else
                        {
                            if (k == 0)
                            {
                                ViTri vt = new ViTri(j, j);
                                CacNuocDi.Add(vt);
                                k++;
                            }
                            else
                                break;

                        }
                    }
                }
                k = 0;
                for (int j = _y - 1; j >= 0; j--)
                {
                    if (banco.Table[j, j] == _flag)
                        break;
                    else
                    {
                        if (banco.Table[j, j] == 0)
                        {
                            ViTri vt = new ViTri(j, j);
                            CacNuocDi.Add(vt);
                        }
                        else
                        {
                            if (k == 0)
                            {
                                ViTri vt = new ViTri(j, j);
                                CacNuocDi.Add(vt);
                                k++;
                            }
                            else
                                break;

                        }
                    }
                }
            }
        }
    }
    public class Rook : QuanCo
    {
        public Rook()
        {
            _live = true;
            _GiaTri = 5;
            
        }
        public override void TimCacNuocDi()
        {
            int _x = this._vitri.x;
            int _y = this._vitri.y;
            CacNuocDi.Clear();
            int k = 0;
            for (int i = _x+1; i < 8; i++)
            {
                if (banco.Table[i, _y] == _flag)
                    break;
                else
                {
                    if (banco.Table[i, _y] == 0)
                    {
                        ViTri vt = new ViTri(i, _y);
                        CacNuocDi.Add(vt);
                    }
                    else
                    {
                        if (k == 0)
                        {
                            ViTri vt = new ViTri(i, _y);
                            CacNuocDi.Add(vt);
                            k++;
                        }
                        else
                            break;
                        
                    }
                }
            }
            k = 0;

            for (int i = _x - 1; i >-1; i--)
            {
                if (banco.Table[i, _y] == _flag)
                    break;
                else
                {
                    if (banco.Table[i, _y] == 0)
                    {
                        ViTri vt = new ViTri(i, _y);
                        CacNuocDi.Add(vt);
                    }
                    else
                    {
                        if (k == 0)
                        {
                            ViTri vt = new ViTri(i, _y);
                            CacNuocDi.Add(vt);
                            k++;
                        }
                        else
                            break;

                    }
                }
            }
            k = 0;

            for (int j = _y + 1; j < 8; j++)
            {
                if (banco.Table[_x,j] == _flag)
                    break;
                else
                {
                    if (banco.Table[_x, j] == 0)
                    {
                        ViTri vt = new ViTri(_x, j);
                        CacNuocDi.Add(vt);
                    }
                    else
                    {
                        if (k == 0)
                        {
                            ViTri vt = new ViTri(_x, j);
                            CacNuocDi.Add(vt);
                            k++;
                        }
                        else
                            break;

                    }
                }
            }
            k = 0;
            for (int j = _y - 1; j >=0; j--)
            {
                if (banco.Table[_x, j] == _flag)
                    break;
                else
                {
                    if (banco.Table[_x, j] == 0)
                    {
                        ViTri vt = new ViTri(_x, j);
                        CacNuocDi.Add(vt);
                    }
                    else
                    {
                        if (k == 0)
                        {
                            ViTri vt = new ViTri(_x, j);
                            CacNuocDi.Add(vt);
                            k++;
                        }
                        else
                            break;

                    }
                }
            }
           
           
        }
    }
    public class Bishop:QuanCo
    {
        public Bishop()
        {
            _live = true;
            _GiaTri = 4;
            
        }
        public override void TimCacNuocDi()
        {
            int _x = this._vitri.x;
            int _y = this._vitri.y;
            CacNuocDi.Clear();
            int k = 0;
            for (int i = _x + 1; i < 8; i++)
            {
                k = 0;
                for (int j = _y + 1; j < 8; j++)
                {
                    if (banco.Table[j, j] == _flag)
                        break;
                    else
                    {
                        if (banco.Table[j, j] == 0)
                        {
                            ViTri vt = new ViTri(j, j);
                            CacNuocDi.Add(vt);
                        }
                        else
                        {
                            if (k == 0)
                            {
                                ViTri vt = new ViTri(j, j);
                                CacNuocDi.Add(vt);
                                k++;
                            }
                            else
                                break;

                        }
                    }
                }
                k = 0;
                for (int j = _y - 1; j >= 0; j--)
                {
                    if (banco.Table[j, j] == _flag)
                        break;
                    else
                    {
                        if (banco.Table[j, j] == 0)
                        {
                            ViTri vt = new ViTri(j, j);
                            CacNuocDi.Add(vt);
                        }
                        else
                        {
                            if (k == 0)
                            {
                                ViTri vt = new ViTri(j, j);
                                CacNuocDi.Add(vt);
                                k++;
                            }
                            else
                                break;

                        }
                    }
                }
            }
            for (int i = _x - 1; i >= 0; i--)
            {
                k = 0;
                for (int j = _y + 1; j < 8; j++)
                {
                    if (banco.Table[j, j] == _flag)
                        break;
                    else
                    {
                        if (banco.Table[j, j] == 0)
                        {
                            ViTri vt = new ViTri(j, j);
                            CacNuocDi.Add(vt);
                        }
                        else
                        {
                            if (k == 0)
                            {
                                ViTri vt = new ViTri(j, j);
                                CacNuocDi.Add(vt);
                                k++;
                            }
                            else
                                break;

                        }
                    }
                }
                k = 0;
                for (int j = _y - 1; j >= 0; j--)
                {
                    if (banco.Table[j, j] == _flag)
                        break;
                    else
                    {
                        if (banco.Table[j, j] == 0)
                        {
                            ViTri vt = new ViTri(j, j);
                            CacNuocDi.Add(vt);
                        }
                        else
                        {
                            if (k == 0)
                            {
                                ViTri vt = new ViTri(j, j);
                                CacNuocDi.Add(vt);
                                k++;
                            }
                            else
                                break;

                        }
                    }
                }
            }
        }
    }
    public class Knight : QuanCo
    {
       public Knight()
       {
           _live = true;
           _GiaTri = 4;
           
       }
        public override void TimCacNuocDi()
        {
            int _x = this._vitri.x;
            int _y = this._vitri.y;
            CacNuocDi.Clear();
            for (int i = _x - 2; i < _x + 3; i++)
            {
                for (int j = _y - 2; j < _y + 3; j++)
                {
                    if ((Math.Abs(i - _x) + Math.Abs(j - _y) == 3) && i >-1 && i < 8 && j >-1 && j < 8)
                    {
                        if (banco.Table[i,j] != _flag)
                        {
                            ViTri vt = new ViTri(i, j);
                            CacNuocDi.Add(vt);
                        }
                        
                    }
                }
            }
        }
    }
    public class Pawn : QuanCo
    {
        int LuotDi;
        int HeSo; // =1 nếu là quân trắng, = -1 nếu là quân đen
        public Pawn()
        {
            _live = true;
            LuotDi = 0;            
            _GiaTri = 1;
            
        }
        public override void TimCacNuocDi()
        {
            int _x = this._vitri.x;
            int _y = this._vitri.y;
            CacNuocDi.Clear();
            if (_flag == 1)
            {
                HeSo = 1;
            }
            if (_flag == 2)
            {
                HeSo = -1;
            }


            if (LuotDi == 0)
            {
                if (banco.Table[_x, HeSo * 1 +_y] != _flag)
                {
                    ViTri vt = new ViTri(_x, HeSo * 1 + _y);
                    CacNuocDi.Add(vt);
                }
               
                if (banco.Table[_x, HeSo * 2] != _flag)
                {
                    if (banco.Table[_x, HeSo * 1 + _y] == 0)
                    {
                        ViTri vt = new ViTri(_x, HeSo * 2 + _y);
                        CacNuocDi.Add(vt);
                    }
                }

                if (_x < 7) {
                    if ((banco.Table[_x + 1, HeSo * 1 + _y] != 0) && (banco.Table[_x + 1, HeSo * 1 + _y] != _flag))
                    {
                        ViTri vtAn = new ViTri(_x + 1, HeSo * 1 + _y);
                        CacNuocDi.Add(vtAn);
                    }
                }
                if (_x > 0)
                {
                    if ((banco.Table[_x - 1, HeSo * 1 + _y] != 0) && (banco.Table[_x - 1, HeSo * 1 + _y] != _flag))
                    {
                        ViTri vtAn = new ViTri(_x + 1, HeSo * 1 + _y);
                        CacNuocDi.Add(vtAn);
                    }
                }
               

                LuotDi++;
            }
            else
            {
                if ((banco.Table[_x, HeSo * 1 + _y] != _flag) && (HeSo * 1 + _y <8))
                {
                    ViTri vt = new ViTri(_x, HeSo * 1 + _y);
                    CacNuocDi.Add(vt);

                    if (_x < 7)
                    {
                        if ((banco.Table[_x + 1, HeSo * 1 + _y] != 0) && (banco.Table[_x + 1, HeSo * 1 + _y] != _flag))
                        {
                            ViTri vtAn = new ViTri(_x + 1, HeSo * 1 + _y);
                            CacNuocDi.Add(vtAn);
                        }
                    }
                    if (_x > 0)
                    {
                        if ((banco.Table[_x - 1, HeSo * 1 + _y] != 0) && (banco.Table[_x - 1, HeSo * 1 + _y] != _flag))
                        {
                            ViTri vtAn = new ViTri(_x + 1, HeSo * 1 + _y);
                            CacNuocDi.Add(vtAn);
                        }
                    }
                }
                LuotDi++;
            }
        }
    }
}
