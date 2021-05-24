using HighSchoolManagerment.Common;
using HighSchoolManagerment.Data.EF;
using HighSchoolManagerment.Data.Entities;
using HighSchoolManagerment.IServices;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HighSchoolManagerment.ServiceImplements
{
    public class BangDiemImp : IBangDiem
    {
        private readonly AppDbContext _context;

        public BangDiemImp(AppDbContext context)
        {
            _context = context;
        }

        public List<BangDiem> Add(int MaND)
        {
            var list = new List<BangDiem>() {
                    new BangDiem(){MaND = MaND, MaMH = "TOANDAISO", MaNH = null, MaHK = 5, MaHL = 5, DiemMiengHK1 = null, Diem15PhutHK1 = null, Diem1TietHK1 = null, DiemThiHK1 = null, DTBHK1 = null, DiemMiengHK2 = null, Diem15PhutHK2 = null, Diem1TietHK2 = null, DiemThiHK2 = null, DTBHK2 = null, CaNam = null},
                    new BangDiem(){MaND = MaND, MaMH = "TOANHINHHOC",  MaNH = null, MaHK = 5, MaHL = 5, DiemMiengHK1 = null, Diem15PhutHK1 = null, Diem1TietHK1 = null, DiemThiHK1 = null, DTBHK1 = null, DiemMiengHK2 = null, Diem15PhutHK2 = null, Diem1TietHK2 = null, DiemThiHK2 = null, DTBHK2 = null, CaNam = null},
                    new BangDiem(){MaND = MaND, MaMH = "LY",  MaNH = null, MaHK = 5, MaHL = 5, DiemMiengHK1 = null, Diem15PhutHK1 = null, Diem1TietHK1 = null, DiemThiHK1 = null, DTBHK1 = null, DiemMiengHK2 = null, Diem15PhutHK2 = null, Diem1TietHK2 = null, DiemThiHK2 = null, DTBHK2 = null, CaNam = null},
                    new BangDiem(){MaND = MaND, MaMH = "HOA",  MaNH = null, MaHK = 5, MaHL = 5, DiemMiengHK1 = null, Diem15PhutHK1 = null, Diem1TietHK1 = null, DiemThiHK1 = null, DTBHK1 = null, DiemMiengHK2 = null, Diem15PhutHK2 = null, Diem1TietHK2 = null, DiemThiHK2 = null, DTBHK2 = null, CaNam = null},
                    new BangDiem(){MaND = MaND, MaMH = "SINH", MaNH = null, MaHK = 5, MaHL = 5, DiemMiengHK1 = null, Diem15PhutHK1 = null, Diem1TietHK1 = null, DiemThiHK1 = null, DTBHK1 = null, DiemMiengHK2 = null, Diem15PhutHK2 = null, Diem1TietHK2 = null, DiemThiHK2 = null, DTBHK2 = null, CaNam = null},
                    new BangDiem(){MaND = MaND, MaMH = "VAN", MaNH = null, MaHK = 5, MaHL = 5, DiemMiengHK1 = null, Diem15PhutHK1 = null, Diem1TietHK1 = null, DiemThiHK1 = null, DTBHK1 = null, DiemMiengHK2 = null, Diem15PhutHK2 = null, Diem1TietHK2 = null, DiemThiHK2 = null, DTBHK2 = null, CaNam = null},
                    new BangDiem(){MaND = MaND, MaMH = "SU", MaNH = null, MaHK = 5, MaHL = 5, DiemMiengHK1 = null, Diem15PhutHK1 = null, Diem1TietHK1 = null, DiemThiHK1 = null, DTBHK1 = null, DiemMiengHK2 = null, Diem15PhutHK2 = null, Diem1TietHK2 = null, DiemThiHK2 = null, DTBHK2 = null, CaNam = null},
                    new BangDiem(){MaND = MaND, MaMH = "DIA", MaNH = null, MaHK = 5, MaHL = 5, DiemMiengHK1 = null, Diem15PhutHK1 = null, Diem1TietHK1 = null, DiemThiHK1 = null, DTBHK1 = null, DiemMiengHK2 = null, Diem15PhutHK2 = null, Diem1TietHK2 = null, DiemThiHK2 = null, DTBHK2 = null, CaNam = null},
                    new BangDiem(){MaND = MaND, MaMH = "ANHVAN", MaNH = null, MaHK = 5, MaHL = 5, DiemMiengHK1 = null, Diem15PhutHK1 = null, Diem1TietHK1 = null, DiemThiHK1 = null, DTBHK1 = null, DiemMiengHK2 = null, Diem15PhutHK2 = null, Diem1TietHK2 = null, DiemThiHK2 = null, DTBHK2 = null, CaNam = null},
                    new BangDiem(){MaND = MaND, MaMH = "CONGNGHE", MaNH = null, MaHK = 5, MaHL = 5, DiemMiengHK1 = null, Diem15PhutHK1 = null, Diem1TietHK1 = null, DiemThiHK1 = null, DTBHK1 = null, DiemMiengHK2 = null, Diem15PhutHK2 = null, Diem1TietHK2 = null, DiemThiHK2 = null, DTBHK2 = null, CaNam = null},
                    new BangDiem(){MaND = MaND, MaMH = "TIN", MaNH = null, MaHK = 5, MaHL = 5, DiemMiengHK1 = null, Diem15PhutHK1 = null, Diem1TietHK1 = null, DiemThiHK1 = null, DTBHK1 = null, DiemMiengHK2 = null, Diem15PhutHK2 = null, Diem1TietHK2 = null, DiemThiHK2 = null, DTBHK2 = null, CaNam = null},
                    new BangDiem(){MaND = MaND, MaMH = "GDCD", MaNH = null, MaHK = 5, MaHL = 5, DiemMiengHK1 = null, Diem15PhutHK1 = null, Diem1TietHK1 = null, DiemThiHK1 = null, DTBHK1 = null, DiemMiengHK2 = null, Diem15PhutHK2 = null, Diem1TietHK2 = null, DiemThiHK2 = null, DTBHK2 = null, CaNam = null},
                    new BangDiem(){MaND = MaND, MaMH = "THEDUC", MaNH = null, MaHK = 5, MaHL = 5, DiemMiengHK1 = null, Diem15PhutHK1 = null, Diem1TietHK1 = null, DiemThiHK1 = null, DTBHK1 = null, DiemMiengHK2 = null, Diem15PhutHK2 = null, Diem1TietHK2 = null, DiemThiHK2 = null, DTBHK2 = null, CaNam = null},
            };
            _context.BangDiem.AddRange(list);
            _context.SaveChanges();

            var models = from bd in _context.BangDiem
                         join hk in _context.HanhKiem on bd.MaHK equals hk.MaHK
                         join hl in _context.HocLuc on bd.MaHL equals hl.MaHL
                         join mh in _context.MonHoc on bd.MaMH equals mh.MaMH
                         join nd in _context.NguoiDung on bd.MaND equals nd.MaND
                         where bd.MaND == MaND
                         orderby mh.Ten
                         select new BangDiem()
                         {
                             MaBD = bd.MaBD,
                             MonHoc = mh,
                             NguoiDung = nd,
                             Diem15PhutHK1 = bd.Diem15PhutHK1,
                             Diem1TietHK1 = bd.Diem1TietHK1,
                             DTBHK1 = bd.DTBHK1,
                             DiemThiHK1 = bd.DiemThiHK1,
                             Diem15PhutHK2 = bd.Diem15PhutHK2,
                             Diem1TietHK2 = bd.Diem1TietHK2,
                             DiemMiengHK1 = bd.DiemMiengHK1,
                             DiemMiengHK2 = bd.DiemMiengHK2,
                             DTBHK2 = bd.DTBHK2,
                             CaNam = bd.CaNam,
                             DiemThiHK2 = bd.DiemThiHK2,
                             HanhKiem = hk,
                             HocLuc = hl,
                             MaHK = bd.MaHK,
                             MaHL = bd.MaHL,
                             MaMH = bd.MaMH,
                             MaND = bd.MaND,
                             MaNH = bd.MaNH
                         };
            return models.ToList();
        }

        public BangDiem GetByMaBD(int MaBD)
        {
            var model = from bd in _context.BangDiem
                        join hk in _context.HanhKiem on bd.MaHK equals hk.MaHK
                        join hl in _context.HocLuc on bd.MaHL equals hl.MaHL
                        join mh in _context.MonHoc on bd.MaMH equals mh.MaMH
                        join nd in _context.NguoiDung on bd.MaND equals nd.MaND
                        where bd.MaBD == MaBD
                        orderby mh.Ten
                        select new BangDiem()
                        {
                            MaBD = bd.MaBD,
                            MonHoc = mh,
                            NguoiDung = nd,
                            Diem15PhutHK1 = bd.Diem15PhutHK1,
                            Diem1TietHK1 = bd.Diem1TietHK1,
                            DTBHK1 = bd.DTBHK1,
                            DiemThiHK1 = bd.DiemThiHK1,
                            Diem15PhutHK2 = bd.Diem15PhutHK2,
                            Diem1TietHK2 = bd.Diem1TietHK2,
                            DiemMiengHK1 = bd.DiemMiengHK1,
                            DiemMiengHK2 = bd.DiemMiengHK2,
                            DTBHK2 = bd.DTBHK2,
                            CaNam = bd.CaNam,
                            DiemThiHK2 = bd.DiemThiHK2,
                            HanhKiem = hk,
                            HocLuc = hl,
                            MaHK = bd.MaHK,
                            MaHL = bd.MaHL,
                            MaMH = bd.MaMH,
                            MaND = bd.MaND,
                            MaNH = bd.MaNH
                        };
            return model.SingleOrDefault();
        }

        public List<BangDiem> GetByUserId(int id)
        {
            var models = (from bd in _context.BangDiem
                         join hk in _context.HanhKiem on bd.MaHK equals hk.MaHK
                         join hl in _context.HocLuc on bd.MaHL equals hl.MaHL
                         join mh in _context.MonHoc on bd.MaMH equals mh.MaMH
                         join nd in _context.NguoiDung on bd.MaND equals nd.MaND
                         where bd.MaND == id
                         orderby mh.Ten
                         select new BangDiem()
                         {
                             MaBD = bd.MaBD,
                             MonHoc = mh,
                             NguoiDung = nd,
                             Diem15PhutHK1 = bd.Diem15PhutHK1,
                             Diem1TietHK1 = bd.Diem1TietHK1,
                             DTBHK1 = bd.DTBHK1,
                             DiemThiHK1 = bd.DiemThiHK1,
                             Diem15PhutHK2 = bd.Diem15PhutHK2,
                             Diem1TietHK2 = bd.Diem1TietHK2,
                             DiemMiengHK1 = bd.DiemMiengHK1,
                             DiemMiengHK2 = bd.DiemMiengHK2,
                             DTBHK2 = bd.DTBHK2,
                             CaNam = bd.CaNam,
                             DiemThiHK2 = bd.DiemThiHK2,
                             HanhKiem = hk,
                             HocLuc = hl,
                             MaHK = bd.MaHK,
                             MaHL = bd.MaHL,
                             MaMH = bd.MaMH,
                             MaND = bd.MaND,
                             MaNH = bd.MaNH
                         }).ToList();
            if (models.Count == 0)
            {
                models = Add(id);
            }
            /*var user = _context.NguoiDung.Where(x => x.MaND == id).FirstOrDefault();



            Dictionary<int, List<BangDiem>> gr = _context.BangDiem
                .Join(_context.LoaiDiem, bd => bd.MaBD, ld => ld.MaLD, (bd, ld) => new { bd, ld })
                .Join(_context.MonHoc, bdld => bdld.bd.MaMH, mh => mh.MaMH, (bdld, mh) => new {bdld, mh})
                .Join(_context.NguoiDung, cb => cb.bdld.bd.MaND, nd => nd.MaND, (cb, nd) => new BangDiem()
                {
                    MaBD = cb.bdld.bd.MaBD,
                    Diem = cb.bdld.bd.Diem,
                    LoaiDiem = cb.bdld.ld,
                    MaLD = cb.bdld.bd.MaLD,
                    NgayTao = cb.bdld.bd.NgayTao,
                    MaND = nd.MaND,
                    MaMH = cb.mh.MaMH,
                    MonHoc = cb.mh,
                    
                    NguoiDung = nd
                }).Where(x => x.MaND == id).ToList().AsEnumerable().GroupBy(k => k.MaLD).ToDictionary(x => x.Key, x => x.ToList());
            var result = new DataResultBangDiem(user, gr);*/



            return models;
        }

        public void Update(BangDiem model)
        {
            var bd = _context.BangDiem.Where(x => x.MaBD == model.MaBD).SingleOrDefault();
            if (model.Diem15PhutHK1 !=null && model.Diem1TietHK1 != null && model.DiemMiengHK1 != null && model.DiemThiHK1 != null)
            {
                bd.DTBHK1 = Math.Round((double)((model.DiemMiengHK1 + model.Diem15PhutHK1 + (model.Diem1TietHK1 * 2) + (model.DiemThiHK1 * 3)) / 7),1);
            }
            if (model.Diem15PhutHK2 != null && model.Diem1TietHK2 != null && model.DiemMiengHK2 != null && model.DiemThiHK2 != null)
            {
                bd.DTBHK2 = Math.Round((double)((model.DiemMiengHK2 + model.Diem15PhutHK2 + (model.Diem1TietHK2 * 2) + (model.DiemThiHK2 * 3)) / 7), 1);
            }
            if (model.DTBHK1 != null && model.DTBHK2 != null)
            {
                bd.CaNam = Math.Round((double)(((model.DTBHK2 * 2) + model.DTBHK1) / 3), 1);
            }
            bd.Diem15PhutHK1 = model.Diem15PhutHK1;
            bd.Diem15PhutHK2 = model.Diem15PhutHK2;
            bd.Diem1TietHK1 = model.Diem1TietHK1;
            bd.Diem1TietHK2 = model.Diem1TietHK2;
            bd.DiemMiengHK1 = model.DiemMiengHK1;
            bd.DiemMiengHK2 = model.DiemMiengHK2;
            bd.DiemThiHK1 = model.DiemThiHK1;
            bd.DiemThiHK2 = model.DiemThiHK2;
            _context.SaveChanges();
        }
    }
}