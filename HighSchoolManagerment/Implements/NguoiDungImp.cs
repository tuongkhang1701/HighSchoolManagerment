using HighSchoolManagerment.Application.Interfaces;
using HighSchoolManagerment.Common;
using HighSchoolManagerment.Data.EF;
using HighSchoolManagerment.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagerment.Application.Implements
{
    public class NguoiDungImp : INguoiDung
    {
        private readonly AppDbContext _context;

        public NguoiDungImp(AppDbContext context)
        {
            _context = context;
        }

        public NguoiDung GetById(int id)
        {
            var user = _context.NguoiDung.Where(x => x.MaND == id).SingleOrDefault();
            return user;
        }

        public void RemoveById(int id)
        {
            var user = _context.NguoiDung.Where(x => x.MaND == id).SingleOrDefault();
            if (user != null)
            {
                _context.NguoiDung.Remove(user);
            }
            _context.SaveChanges();
        }

        public IQueryable<GioiTinh> GetGender()
        {
            return _context.GioiTinh;
        }

        public IQueryable<TonGiao> GetReligion()
        {
            return _context.TonGiao;
        }

        public IQueryable<NguoiDung> GetAll()
        {
            var users = from u in _context.NguoiDung
                        join g in _context.GioiTinh on u.MaGT equals g.MaGT
                        join r in _context.TonGiao on u.MaTG equals r.MaTG
                        join ug in _context.NhomNguoiDung on u.MaNND equals ug.MaNND
                        select new NguoiDung()
                        {
                            MaND = u.MaND,
                            HinhAnh = u.HinhAnh,
                            HoTen = u.HoTen,
                            GioiTinh = g,
                            MatKhau = u.MatKhau,
                            TonGiao = r,
                            NhomNguoiDung = ug
                        };
            return users;
        }

        public void Update(NguoiDung user)
        {
            _context.NguoiDung.Update(user);
            _context.SaveChanges();
        }

        public void Add(NguoiDung user)
        {
            _context.NguoiDung.Add(user);
            _context.SaveChanges();
        }

        public async Task<PaginationResult<NguoiDung>> GetAllPaging(GetUserPagingRequest request)
        {
            var query = from u in _context.NguoiDung
                        join g in _context.GioiTinh on u.MaGT equals g.MaGT
                        join r in _context.TonGiao on u.MaTG equals r.MaTG
                        join ug in _context.NhomNguoiDung on u.MaNND equals ug.MaNND
                        select new NguoiDung()
                        {
                            MaND = u.MaND,
                            HinhAnh = u.HinhAnh,
                            SDT = u.SDT,
                            HoTen = u.HoTen,
                            GioiTinh = g,
                            MatKhau = u.MatKhau,
                            TonGiao = r,
                            NhomNguoiDung = ug
                        };
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.HoTen.Contains(request.Keyword));
            }
            if (!string.IsNullOrEmpty(request.UserGroupId))
            {
                query = query.Where(x => x.NhomNguoiDung.MaNND == request.UserGroupId);
            }
            var totalCount = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize).ToListAsync();

            var pagination = new PaginationResult<NguoiDung>()
            {
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                TotalRecord = totalCount,
                Data = data
            };

            return pagination;
        }

        public IQueryable<NhomNguoiDung> GetUserGroup()
        {
            return _context.NhomNguoiDung;
        }
    }
}