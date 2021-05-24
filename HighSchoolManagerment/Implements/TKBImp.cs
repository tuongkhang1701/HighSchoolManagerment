using HighSchoolManagerment.Data.EF;
using HighSchoolManagerment.Data.Entities;
using HighSchoolManagerment.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HighSchoolManagerment.Implements
{
    public class TKBImp : ITKB
    {
        public readonly AppDbContext _context;

        public TKBImp(AppDbContext context)
        {
            _context = context;
        }

        public List<TKB> GetAll(int MaLop)
        {
            var list = (from t in _context.TKB
                        join m in _context.MonHoc on t.MaMH equals m.MaMH
                        join n in _context.NamHoc on t.MaNH equals n.MaNH
                        join l in _context.Lop on t.MaLop equals l.MaLop
                        where t.MaLop == MaLop
                        select new TKB()
                        {
                            MaLop = t.MaLop,
                            MaMH = t.MaMH,
                            Lop = l,
                            MaTKB = t.MaTKB,
                            MonHoc = m,
                            Thu = t.Thu,
                            Tiet = t.Tiet,
                            Buoi = t.Buoi,
                            MaNH = t.MaNH,
                            NamHoc = n
                        }).OrderBy(x => x.Tiet).ThenBy(y => y.Thu).ToList();
            return list;
        }

        public List<TKB> GetByBuoi(int MaNH, string Buoi)
        {
            var list = GetByNH(MaNH).Where(x => x.Buoi == Buoi).OrderBy(x => x.Tiet).ThenBy(y => y.Thu).ToList();
            return list;
        }

        public List<TKB> GetByBuoi(string Buoi)
        {
            throw new System.NotImplementedException();
        }

        public List<TKB> GetByMaLop(int MaNH, string Buoi, int MaLop)
        {
            var list = GetByBuoi(MaNH, Buoi).Where(x => x.MaLop == MaLop).OrderBy(x => x.Tiet).ThenBy(y => y.Thu).ToList();
            return list;
        }

        public List<TKB> GetByMaLop(int MaLop)
        {
            throw new System.NotImplementedException();
        }

        public List<TKB> GetByNH(int MaNH)
        {
            var list = (from t in _context.TKB
                        join m in _context.MonHoc on t.MaMH equals m.MaMH
                        join n in _context.NamHoc on t.MaNH equals n.MaNH
                        join l in _context.Lop on t.MaLop equals l.MaLop
                        where t.MaNH == MaNH
                        select new TKB()
                        {
                            MaLop = t.MaLop,
                            MaMH = t.MaMH,
                            Lop = l,
                            MaTKB = t.MaTKB,
                            MonHoc = m,
                            Thu = t.Thu,
                            Tiet = t.Tiet,
                            MaNH = t.MaNH,
                            Buoi = t.Buoi,
                            NamHoc = n
                        }).OrderBy(x => x.Tiet).ThenBy(y => y.Thu).ToList();
            return list;
        }

        public List<TKB> GetBySelection(int MaNH, string Buoi, int MaLop)
        {
            var list = (from t in _context.TKB
                        join m in _context.MonHoc on t.MaMH equals m.MaMH
                        join l in _context.Lop on t.MaLop equals l.MaLop
                        where t.Buoi == Buoi
                        select new TKB()
                        {
                            MaLop = t.MaLop,
                            MaMH = t.MaMH,
                            Lop = l,
                            MaTKB = t.MaTKB,
                            MonHoc = m,
                            Thu = t.Thu,
                            Tiet = t.Tiet
                        }).OrderBy(x => x.Tiet).ThenBy(y => y.Thu).ToList();
            return list;
        }

        public List<TKB> GetBySelection(int MaLop)
        {
            throw new System.NotImplementedException();
        }
    }
}