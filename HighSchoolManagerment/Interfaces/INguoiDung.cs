using HighSchoolManagerment.Common;
using HighSchoolManagerment.Data.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagerment.Application.Interfaces
{
    public interface INguoiDung
    {
        void RemoveById(int id);

        NguoiDung GetById(int id);

        

        void Update(NguoiDung user);

        void Add(NguoiDung user);

        Task<PaginationResult<NguoiDung>> GetAllPaging(GetUserPagingRequest request);

        IQueryable<GioiTinh> GetGender();

        IQueryable<TonGiao> GetReligion();

        IQueryable<NhomNguoiDung> GetUserGroup();

        IQueryable<NguoiDung> GetAll();
    }
}