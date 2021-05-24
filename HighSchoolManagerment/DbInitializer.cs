using HighSchoolManagerment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagerment.Data.EF
{
    public class DbInitializer
    {
        private readonly AppDbContext _context;

        public DbInitializer(AppDbContext context)
        {
            _context = context;
        }

        public async Task Seeding()
        {
            if (_context.Quyen.Count() == 0)
            {
                var roles = new List<Quyen>()
                {
                    new Quyen(){MaQ = "VIEW_STUDENT", Ten = "Xem danh sách học sinh"},
                    new Quyen(){MaQ = "DELETE_STUDENT", Ten = "Xóa học sinh"},
                    new Quyen(){MaQ = "EDIT_STUDENT", Ten = "Cập nhât học sinh"},
                    new Quyen(){MaQ = "ADD_STUDENT", Ten = "Thêm học sinh"},

                    new Quyen(){MaQ = "VIEW_TEACHER", Ten = "Xem danh sách giáo viên"},
                    new Quyen(){MaQ = "DELETE_TEACHER", Ten = "Xóa giáo viên"},
                    new Quyen(){MaQ = "EDIT_TEACHER", Ten = "Cập nhât giáo viên"},
                    new Quyen(){MaQ = "ADD_TEACHER", Ten = "Thêm học giáo viên"},

                    new Quyen(){MaQ = "VIEW_SCOREBOARD", Ten = "Xem bảng điểm"},
                    new Quyen(){MaQ = "DELETE_SCOREBOARD", Ten = "Xóa bảng điểm"},
                    new Quyen(){MaQ = "EDIT_SCOREBOARD", Ten = "Cập nhât bảng điểm"},
                    new Quyen(){MaQ = "ADD_SCOREBOARD", Ten = "Thêm bảng điểm"},

                    new Quyen(){MaQ = "VIEW_TKB", Ten = "Xem thời khóa biểu"},  
                    new Quyen(){MaQ = "DELETE_TKB", Ten = "Xóa thời khóa biểu"},
                    new Quyen(){MaQ = "EDIT_TKB", Ten = "Cập nhât thời khóa biểu"},
                    new Quyen(){MaQ = "ADD_TKB", Ten = "Thêm thời khóa biểu"}
                };
                await _context.AddRangeAsync(roles);
            }

            if (_context.NamHoc.Count() == 0)
            {
                var roles = new List<NamHoc>()
                {
                    new NamHoc(){Ten = "2018-2019"},
                    new NamHoc(){Ten = "2019-2020"},
                    new NamHoc(){Ten = "2020-2021"},

                };
                await _context.AddRangeAsync(roles);
            }
            await _context.SaveChangesAsync();

            if (_context.NhomNguoiDung.Count() == 0)
            {
                var userGroups = new List<NhomNguoiDung>()
                {
                    new NhomNguoiDung(){Ten = "Học vụ", MaNND = "HOCVU"},
                    new NhomNguoiDung(){Ten = "Giáo viên", MaNND = "GIAOVIEN"},
                    new NhomNguoiDung(){Ten = "Học sinh", MaNND = "HOCSINH"}
                };
                await _context.AddRangeAsync(userGroups);
            }
            await _context.SaveChangesAsync();



            if (_context.MonHoc.Count() == 0)
            {
                var subjects = new List<MonHoc>()
                {
                    new MonHoc(){Ten = "Sinh hoạt lớp", MaMH = "SINHHOATLOP"},
                    new MonHoc(){Ten = "Chào cờ", MaMH = "CHAOCO"},
                    new MonHoc(){Ten = "Toán đại số", MaMH = "TOANDAISO"},
                    new MonHoc(){Ten = "Toán hình học", MaMH = "TOANHINHHOC"},
                    new MonHoc(){Ten = "Lý", MaMH = "LY"},
                    new MonHoc(){Ten = "Hóa", MaMH = "HOA"},
                    new MonHoc(){Ten = "Sinh", MaMH = "SINH"},
                    new MonHoc(){Ten = "Văn", MaMH = "VAN"},
                    new MonHoc(){Ten = "Sử", MaMH = "SU"},
                    new MonHoc(){Ten = "Địa", MaMH = "DIA"},
                    new MonHoc(){Ten = "Tiếng Anh", MaMH = "ANHVAN"},
                    new MonHoc(){Ten = "Công nghệ", MaMH = "CONGNGHE"},
                    new MonHoc(){Ten = "Tin học", MaMH = "TIN"},
                    new MonHoc(){Ten = "Giáo dục công dân", MaMH = "GDCD"},
                    new MonHoc(){Ten = "Thể dục", MaMH = "THEDUC"},
                    new MonHoc(){Ten = "Trống", MaMH = "TRONG"}
                };
                await _context.AddRangeAsync(subjects);
            }

            if (_context.HanhKiem.Count() == 0)
            {
                var loaiDiems = new List<HanhKiem>()
                {
                    new HanhKiem(){Ten = "Tốt"},
                    new HanhKiem(){Ten = "Khá"},
                    new HanhKiem(){Ten = "Trung bình"},
                    new HanhKiem(){Ten = "Yếu"},
                    new HanhKiem(){Ten = "Chưa xác định"}
                };
                await _context.AddRangeAsync(loaiDiems);
            }

            if (_context.HocLuc.Count() == 0)
            {
                var loaiDiems = new List<HocLuc>()
                {
                    new HocLuc(){Ten = "Tốt"},
                    new HocLuc(){Ten = "Khá"},
                    new HocLuc(){Ten = "Trung bình"},
                    new HocLuc(){Ten = "Yếu"},
                    new HocLuc(){Ten = "Chưa xác định"}
                };
                await _context.AddRangeAsync(loaiDiems);
            }
            await _context.SaveChangesAsync();

            

            if (_context.TonGiao.Count() == 0)
            {
                var religions = new List<TonGiao>()
                {
                    new TonGiao(){Ten = "Phật giáo"},
                    new TonGiao(){Ten = "Công giáo"},
                    new TonGiao(){Ten = "Đạo Hồi"},
                    new TonGiao(){Ten = "Tin Lành"},
                    new TonGiao(){Ten = "Cao Đài"},
                    new TonGiao(){Ten = "Hòa Hảo"},
                    new TonGiao(){Ten = "Ấn Độ giáo"},
                    new TonGiao(){Ten = "Hồi giáo"},
                    new TonGiao(){Ten = "Tôn giáo khác"},
                    new TonGiao(){Ten = "Không tôn giáo"},
                };
                await _context.AddRangeAsync(religions);
            }

            if (_context.GioiTinh.Count() == 0)
            {
                var genders = new List<GioiTinh>()
                {
                    new GioiTinh(){Ten = "Nam"},
                    new GioiTinh(){Ten = "Nữ"},
                    new GioiTinh(){Ten = "Khác"}
                };
                await _context.AddRangeAsync(genders);
            }

            if (_context.Lop.Count() == 0)
            {
                var grades = new List<Lop>()
                {
                    new Lop(){Ten = "10A1"}
                };
                await _context.AddRangeAsync(grades);
            }
            await _context.SaveChangesAsync();

            if (_context.NguoiDung.Count() == 0)
            {
                var users = new List<NguoiDung>() {
                    new NguoiDung(){HoTen = "Teacher A", MaGT = 1, MaTG = 1, MaLop = null, HinhAnh = "AA",SDT = "123456789",MaNND = "GIAOVIEN", MatKhau = "123456" },
                    new NguoiDung(){HoTen = "Teacher B", MaGT = 1, MaTG = 1, MaLop = null, HinhAnh = "AA",SDT = "123456789",MaNND = "GIAOVIEN", MatKhau = "123456" },
                    new NguoiDung(){HoTen = "LÊ VĂN B", MaGT = 1, MaTG = 1, MaLop = 1, HinhAnh = "AA",SDT = "123456789",MaNND = "HOCSINH", MatKhau = "123456"},
                    new NguoiDung(){HoTen = "LÊ VĂN C", MaGT= 1, MaTG = 1, MaLop = 1, HinhAnh = "AA",SDT = "123456789",MaNND = "HOCSINH", MatKhau = "123456"}
                };
                await _context.AddRangeAsync(users);
            }
            await _context.SaveChangesAsync();


            if (_context.BangDiem.Count() == 0)
            {
                var boards = new List<BangDiem>()
                {
                    new BangDiem(){MaND = 1, MaMH = "TOANDAISO", MaNH = 1, MaHK = null, HanhKiem = null, MaHL = null, DiemMiengHK1 = null, Diem15PhutHK1 = null, Diem1TietHK1 = null, DiemThiHK1 = null, DTBHK1 = null, DiemMiengHK2 = null, Diem15PhutHK2 = null, Diem1TietHK2 = null, DiemThiHK2 = null, DTBHK2 = null, CaNam = null},

                    new BangDiem(){MaND = 1, MaMH = "TOANHINHHOC",  MaNH = 1, MaHK = null, MaHL = null, DiemMiengHK1 = null, Diem15PhutHK1 = null, Diem1TietHK1 = null, DiemThiHK1 = null, DTBHK1 = null, DiemMiengHK2 = null, Diem15PhutHK2 = null, Diem1TietHK2 = null, DiemThiHK2 = null, DTBHK2 = null, CaNam = null},
                    new BangDiem(){MaND = 1, MaMH = "LY",  MaNH = 1, MaHK = null, MaHL = null, DiemMiengHK1 = null, Diem15PhutHK1 = null, Diem1TietHK1 = null, DiemThiHK1 = null, DTBHK1 = null, DiemMiengHK2 = null, Diem15PhutHK2 = null, Diem1TietHK2 = null, DiemThiHK2 = null, DTBHK2 = null, CaNam = null},
                    new BangDiem(){MaND = 1, MaMH = "HOA",  MaNH = 1, MaHK = null, MaHL = null, DiemMiengHK1 = null, Diem15PhutHK1 = null, Diem1TietHK1 = null, DiemThiHK1 = null, DTBHK1 = null, DiemMiengHK2 = null, Diem15PhutHK2 = null, Diem1TietHK2 = null, DiemThiHK2 = null, DTBHK2 = null, CaNam = null},
                    new BangDiem(){MaND = 1, MaMH = "SINH", MaNH = 1, MaHK = null, MaHL = null, DiemMiengHK1 = null, Diem15PhutHK1 = null, Diem1TietHK1 = null, DiemThiHK1 = null, DTBHK1 = null, DiemMiengHK2 = null, Diem15PhutHK2 = null, Diem1TietHK2 = null, DiemThiHK2 = null, DTBHK2 = null, CaNam = null},
                    new BangDiem(){MaND = 1, MaMH = "VAN", MaNH = 1, MaHK = null, MaHL = null, DiemMiengHK1 = null, Diem15PhutHK1 = null, Diem1TietHK1 = null, DiemThiHK1 = null, DTBHK1 = null, DiemMiengHK2 = null, Diem15PhutHK2 = null, Diem1TietHK2 = null, DiemThiHK2 = null, DTBHK2 = null, CaNam = null},
                    new BangDiem(){MaND = 1, MaMH = "SU", MaNH = 1, MaHK = null, MaHL = null, DiemMiengHK1 = null, Diem15PhutHK1 = null, Diem1TietHK1 = null, DiemThiHK1 = null, DTBHK1 = null, DiemMiengHK2 = null, Diem15PhutHK2 = null, Diem1TietHK2 = null, DiemThiHK2 = null, DTBHK2 = null, CaNam = null},
                    new BangDiem(){MaND = 1, MaMH = "DIA", MaNH = 1, MaHK = null, MaHL = null, DiemMiengHK1 = null, Diem15PhutHK1 = null, Diem1TietHK1 = null, DiemThiHK1 = null, DTBHK1 = null, DiemMiengHK2 = null, Diem15PhutHK2 = null, Diem1TietHK2 = null, DiemThiHK2 = null, DTBHK2 = null, CaNam = null},
                    new BangDiem(){MaND = 1, MaMH = "ANHVAN", MaNH = 1, MaHK = null, MaHL = null, DiemMiengHK1 = null, Diem15PhutHK1 = null, Diem1TietHK1 = null, DiemThiHK1 = null, DTBHK1 = null, DiemMiengHK2 = null, Diem15PhutHK2 = null, Diem1TietHK2 = null, DiemThiHK2 = null, DTBHK2 = null, CaNam = null},
                    new BangDiem(){MaND = 1, MaMH = "CONGNGHE", MaNH = 1, MaHK = null, MaHL = null, DiemMiengHK1 = null, Diem15PhutHK1 = null, Diem1TietHK1 = null, DiemThiHK1 = null, DTBHK1 = null, DiemMiengHK2 = null, Diem15PhutHK2 = null, Diem1TietHK2 = null, DiemThiHK2 = null, DTBHK2 = null, CaNam = null},
                    new BangDiem(){MaND = 1, MaMH = "TIN", MaNH = 1, MaHK = null, MaHL = null, DiemMiengHK1 = null, Diem15PhutHK1 = null, Diem1TietHK1 = null, DiemThiHK1 = null, DTBHK1 = null, DiemMiengHK2 = null, Diem15PhutHK2 = null, Diem1TietHK2 = null, DiemThiHK2 = null, DTBHK2 = null, CaNam = null},
                    new BangDiem(){MaND = 1, MaMH = "GDCD", MaNH = 1, MaHK = null, MaHL = null, DiemMiengHK1 = null, Diem15PhutHK1 = null, Diem1TietHK1 = null, DiemThiHK1 = null, DTBHK1 = null, DiemMiengHK2 = null, Diem15PhutHK2 = null, Diem1TietHK2 = null, DiemThiHK2 = null, DTBHK2 = null, CaNam = null},
                    new BangDiem(){MaND = 1, MaMH = "THEDUC", MaNH = 1, MaHK = null, MaHL = null, DiemMiengHK1 = null, Diem15PhutHK1 = null, Diem1TietHK1 = null, DiemThiHK1 = null, DTBHK1 = null, DiemMiengHK2 = null, Diem15PhutHK2 = null, Diem1TietHK2 = null, DiemThiHK2 = null, DTBHK2 = null, CaNam = null}

                };
                await _context.AddRangeAsync(boards);
            }
            await _context.SaveChangesAsync();

            if (_context.TKB.Count() == 0)
            {
                var timeTables = new List<TKB>()
                {
                    new TKB(){Thu = "Thứ 2", Tiet = 1, MaMH = "CHAOCO", MaLop = 1, MaNH = 1, Buoi = "Sáng"},
                    new TKB(){Thu = "Thứ 2", Tiet = 2, MaMH = "HOA", MaLop = 1, MaNH = 1, Buoi = "Sáng"},
                    new TKB(){Thu = "Thứ 2", Tiet = 3, MaMH = "LY", MaLop = 1, MaNH = 1, Buoi = "Sáng"},
                    new TKB(){Thu = "Thứ 2", Tiet = 4, MaMH = "LY", MaLop = 1, MaNH = 1, Buoi = "Sáng"},
                    new TKB(){Thu = "Thứ 2", Tiet = 5, MaMH = "LY", MaLop = 1, MaNH = 1, Buoi = "Sáng"},

                    new TKB(){Thu = "Thứ 3", Tiet = 1, MaMH = "ANHVAN", MaLop = 1, MaNH = 1, Buoi = "Sáng"},
                    new TKB(){Thu = "Thứ 3", Tiet = 2, MaMH = "ANHVAN", MaLop = 1, MaNH = 1, Buoi = "Sáng"},
                    new TKB(){Thu = "Thứ 3", Tiet = 3, MaMH = "LY", MaLop = 1, MaNH = 1, Buoi = "Sáng"},
                    new TKB(){Thu = "Thứ 3", Tiet = 4, MaMH = "TOANDAISO", MaLop = 1, MaNH = 1, Buoi = "Sáng"},
                    new TKB(){Thu = "Thứ 3", Tiet = 5, MaMH = "TOANDAISO", MaLop = 1, MaNH = 1, Buoi = "Sáng"},

                    new TKB(){Thu = "Thứ 4", Tiet = 1, MaMH = "TOANDAISO", MaLop = 1, MaNH = 1, Buoi = "Sáng"},
                    new TKB(){Thu = "Thứ 4", Tiet = 2, MaMH = "SINH", MaLop = 1, MaNH = 1, Buoi = "Sáng"},
                    new TKB(){Thu = "Thứ 4", Tiet = 3, MaMH = "VAN", MaLop = 1, MaNH = 1, Buoi = "Sáng"},
                    new TKB(){Thu = "Thứ 4", Tiet = 4, MaMH = "TRONG", MaLop = 1, MaNH = 1, Buoi = "Sáng"},
                    new TKB(){Thu = "Thứ 4", Tiet = 5, MaMH = "TRONG", MaLop = 1, MaNH = 1, Buoi = "Sáng"},

                    new TKB(){Thu = "Thứ 5", Tiet = 1, MaMH = "TRONG", MaLop = 1, MaNH = 1, Buoi = "Sáng"},
                    new TKB(){Thu = "Thứ 5", Tiet = 2, MaMH = "TRONG", MaLop = 1, MaNH = 1, Buoi = "Sáng"},
                    new TKB(){Thu = "Thứ 5", Tiet = 3, MaMH = "TRONG", MaLop = 1, MaNH = 1, Buoi = "Sáng"},
                    new TKB(){Thu = "Thứ 5", Tiet = 4, MaMH = "TRONG", MaLop = 1, MaNH = 1, Buoi = "Sáng"},
                    new TKB(){Thu = "Thứ 5", Tiet = 5, MaMH = "TRONG", MaLop = 1, MaNH = 1, Buoi = "Sáng"},

                    new TKB(){Thu = "Thứ 6", Tiet = 1, MaMH = "TRONG", MaLop = 1, MaNH = 1, Buoi = "Sáng"},
                    new TKB(){Thu = "Thứ 6", Tiet = 2, MaMH = "TRONG", MaLop = 1, MaNH = 1, Buoi = "Sáng"},
                    new TKB(){Thu = "Thứ 6", Tiet = 3, MaMH = "TRONG", MaLop = 1, MaNH = 1, Buoi = "Sáng"},
                    new TKB(){Thu = "Thứ 6", Tiet = 4, MaMH = "TRONG", MaLop = 1, MaNH = 1, Buoi = "Sáng"},
                    new TKB(){Thu = "Thứ 6", Tiet = 5, MaMH = "TRONG", MaLop = 1, MaNH = 1, Buoi = "Sáng"},

                    new TKB(){Thu = "Thứ 7", Tiet = 1, MaMH = "TRONG", MaLop = 1, MaNH = 1, Buoi = "Sáng"},
                    new TKB(){Thu = "Thứ 7", Tiet = 2, MaMH = "TRONG", MaLop = 1, MaNH = 1, Buoi = "Sáng"},
                    new TKB(){Thu = "Thứ 7", Tiet = 3, MaMH = "TRONG", MaLop = 1, MaNH = 1, Buoi = "Sáng"},
                    new TKB(){Thu = "Thứ 7", Tiet = 4, MaMH = "TRONG", MaLop = 1, MaNH = 1, Buoi = "Sáng"},
                    new TKB(){Thu = "Thứ 7", Tiet = 5, MaMH = "TRONG", MaLop = 1, MaNH = 1, Buoi = "Sáng"},


                };
                await _context.AddRangeAsync(timeTables);
            }

            

            /*if (_context.Permissions.Count() == 0)
            {
                var permissions = new List<Permission>()
                {
                    new Permission(){UserGroupId = "HIEUTRUONG", RoleId = null},
                    new Permission(){UserGroupId = "HIEUTRUONG", RoleId = null},
                    new Permission(){UserGroupId = "HIEUTRUONG", RoleId = null},
                    new Permission(){UserGroupId = "HIEUTRUONG", RoleId = null},

                    new Permission(){UserGroupId = "HOCVU", RoleId = null},
                    new Permission(){UserGroupId = "HOCVU", RoleId = null},
                    new Permission(){UserGroupId = "HOCVU", RoleId = null},
                    new Permission(){UserGroupId = "HOCVU", RoleId = null},

                    new Permission(){UserGroupId = "TRUONGTOAN", RoleId = null},
                    new Permission(){UserGroupId = "TRUONGTOAN", RoleId = null},
                    new Permission(){UserGroupId = "TRUONGTOAN", RoleId = null},
                    new Permission(){UserGroupId = "HOCVU", RoleId = null},
                };
                await _context.AddRangeAsync(permissions);
            }*/
            

            if (_context.ChucNang.Count() == 0)
            {
                var functions = new List<ChucNang>()
                {
                    new ChucNang(){MaCN = "student", Ten = "Tùy chọn học sinh", IconCss = "fa-user", MaCNCha = null, Url = "/admin/nguoidung/index?UserGroupId=HOCSINH"},
                    new ChucNang(){MaCN = "teacher", Ten = "Tùy chọn giáo viên", IconCss = "fa-user", MaCNCha = null, Url = "/admin/nguoidung/index?UserGroupId=GIAOVIEN"},
                    new ChucNang(){MaCN = "time-table", Ten = "Thời khóa biểu", IconCss = "fa-table", MaCNCha = null, Url = "/admin/tkb/index"},
                    new ChucNang(){MaCN = "score-board", Ten = "Bảng điểm", IconCss = "fa-book", MaCNCha = null, Url = "/admin/bangdiem/index"},
                    new ChucNang(){MaCN = "class", Ten = "Tùy chọn lớp", IconCss = "fa-users", MaCNCha = null, Url = "/admin/lop/index"},
                    new ChucNang(){MaCN = "help", Ten = "Trợ giúp", IconCss = "fa-question-circle", MaCNCha = null, Url = "/admin/trogiup/index"}
                };
                await _context.AddRangeAsync(functions);
            }

            await _context.SaveChangesAsync();

            
        }
    }
}