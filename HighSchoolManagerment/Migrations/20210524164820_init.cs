using Microsoft.EntityFrameworkCore.Migrations;

namespace HighSchoolManagerment.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChucNang",
                columns: table => new
                {
                    MaCN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IconCss = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MaCNCha = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Url = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucNang", x => x.MaCN);
                });

            migrationBuilder.CreateTable(
                name: "GioiTinh",
                columns: table => new
                {
                    MaGT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioiTinh", x => x.MaGT);
                });

            migrationBuilder.CreateTable(
                name: "HanhKiem",
                columns: table => new
                {
                    MaHK = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HanhKiem", x => x.MaHK);
                });

            migrationBuilder.CreateTable(
                name: "HocLuc",
                columns: table => new
                {
                    MaHL = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocLuc", x => x.MaHL);
                });

            migrationBuilder.CreateTable(
                name: "MonHoc",
                columns: table => new
                {
                    MaMH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonHoc", x => x.MaMH);
                });

            migrationBuilder.CreateTable(
                name: "NamHoc",
                columns: table => new
                {
                    MaNH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NamHoc", x => x.MaNH);
                });

            migrationBuilder.CreateTable(
                name: "NhomNguoiDung",
                columns: table => new
                {
                    MaNND = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhomNguoiDung", x => x.MaNND);
                });

            migrationBuilder.CreateTable(
                name: "Quyen",
                columns: table => new
                {
                    MaQ = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quyen", x => x.MaQ);
                });

            migrationBuilder.CreateTable(
                name: "TonGiao",
                columns: table => new
                {
                    MaTG = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TonGiao", x => x.MaTG);
                });

            migrationBuilder.CreateTable(
                name: "Lop",
                columns: table => new
                {
                    MaLop = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NamHocMaNH = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lop", x => x.MaLop);
                    table.ForeignKey(
                        name: "FK_Lop_NamHoc_NamHocMaNH",
                        column: x => x.NamHocMaNH,
                        principalTable: "NamHoc",
                        principalColumn: "MaNH",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VaiTro",
                columns: table => new
                {
                    MaVT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaNND = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    UserGroupId = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaiTro", x => new { x.MaVT, x.MaNND });
                    table.ForeignKey(
                        name: "FK_VaiTro_NhomNguoiDung_UserGroupId",
                        column: x => x.UserGroupId,
                        principalTable: "NhomNguoiDung",
                        principalColumn: "MaNND",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VaiTro_Quyen_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Quyen",
                        principalColumn: "MaQ",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NguoiDung",
                columns: table => new
                {
                    MaND = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    MaGT = table.Column<int>(type: "int", nullable: false),
                    MaTG = table.Column<int>(type: "int", nullable: false),
                    MaLop = table.Column<int>(type: "int", nullable: true),
                    MatKhau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaNND = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDung", x => x.MaND);
                    table.ForeignKey(
                        name: "FK_NguoiDung_GioiTinh_MaGT",
                        column: x => x.MaGT,
                        principalTable: "GioiTinh",
                        principalColumn: "MaGT",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NguoiDung_Lop_MaLop",
                        column: x => x.MaLop,
                        principalTable: "Lop",
                        principalColumn: "MaLop",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NguoiDung_NhomNguoiDung_MaNND",
                        column: x => x.MaNND,
                        principalTable: "NhomNguoiDung",
                        principalColumn: "MaNND",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NguoiDung_TonGiao_MaTG",
                        column: x => x.MaTG,
                        principalTable: "TonGiao",
                        principalColumn: "MaTG",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TKB",
                columns: table => new
                {
                    MaTKB = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Thu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tiet = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    MaLop = table.Column<int>(type: "int", nullable: false),
                    MaMH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MaNH = table.Column<int>(type: "int", nullable: false),
                    Buoi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TKB", x => x.MaTKB);
                    table.ForeignKey(
                        name: "FK_TKB_Lop_MaLop",
                        column: x => x.MaLop,
                        principalTable: "Lop",
                        principalColumn: "MaLop",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TKB_MonHoc_MaMH",
                        column: x => x.MaMH,
                        principalTable: "MonHoc",
                        principalColumn: "MaMH",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TKB_NamHoc_MaNH",
                        column: x => x.MaNH,
                        principalTable: "NamHoc",
                        principalColumn: "MaNH",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BangDiem",
                columns: table => new
                {
                    MaBD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaND = table.Column<int>(type: "int", nullable: true),
                    MaMH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DiemMiengHK1 = table.Column<double>(type: "float", nullable: true),
                    Diem15PhutHK1 = table.Column<double>(type: "float", nullable: true),
                    Diem1TietHK1 = table.Column<double>(type: "float", nullable: true),
                    DiemThiHK1 = table.Column<double>(type: "float", nullable: true),
                    DTBHK1 = table.Column<double>(type: "float", nullable: true),
                    DiemMiengHK2 = table.Column<double>(type: "float", nullable: true),
                    Diem15PhutHK2 = table.Column<double>(type: "float", nullable: true),
                    Diem1TietHK2 = table.Column<double>(type: "float", nullable: true),
                    DiemThiHK2 = table.Column<double>(type: "float", nullable: true),
                    DTBHK2 = table.Column<double>(type: "float", nullable: true),
                    CaNam = table.Column<double>(type: "float", nullable: true),
                    MaHK = table.Column<int>(type: "int", nullable: true),
                    MaHL = table.Column<int>(type: "int", nullable: true),
                    MaNH = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BangDiem", x => x.MaBD);
                    table.ForeignKey(
                        name: "FK_BangDiem_HanhKiem_MaHK",
                        column: x => x.MaHK,
                        principalTable: "HanhKiem",
                        principalColumn: "MaHK",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BangDiem_HocLuc_MaHL",
                        column: x => x.MaHL,
                        principalTable: "HocLuc",
                        principalColumn: "MaHL",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BangDiem_MonHoc_MaMH",
                        column: x => x.MaMH,
                        principalTable: "MonHoc",
                        principalColumn: "MaMH",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BangDiem_NguoiDung_MaND",
                        column: x => x.MaND,
                        principalTable: "NguoiDung",
                        principalColumn: "MaND",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NguoiDungLop",
                columns: table => new
                {
                    MaND = table.Column<int>(type: "int", nullable: false),
                    MaLop = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDungLop", x => new { x.MaND, x.MaLop });
                    table.ForeignKey(
                        name: "FK_NguoiDungLop_Lop_MaLop",
                        column: x => x.MaLop,
                        principalTable: "Lop",
                        principalColumn: "MaLop",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NguoiDungLop_NguoiDung_MaND",
                        column: x => x.MaND,
                        principalTable: "NguoiDung",
                        principalColumn: "MaND",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BangDiem_MaHK",
                table: "BangDiem",
                column: "MaHK");

            migrationBuilder.CreateIndex(
                name: "IX_BangDiem_MaHL",
                table: "BangDiem",
                column: "MaHL");

            migrationBuilder.CreateIndex(
                name: "IX_BangDiem_MaMH",
                table: "BangDiem",
                column: "MaMH");

            migrationBuilder.CreateIndex(
                name: "IX_BangDiem_MaND",
                table: "BangDiem",
                column: "MaND");

            migrationBuilder.CreateIndex(
                name: "IX_Lop_NamHocMaNH",
                table: "Lop",
                column: "NamHocMaNH");

            migrationBuilder.CreateIndex(
                name: "IX_NguoiDung_MaGT",
                table: "NguoiDung",
                column: "MaGT");

            migrationBuilder.CreateIndex(
                name: "IX_NguoiDung_MaLop",
                table: "NguoiDung",
                column: "MaLop");

            migrationBuilder.CreateIndex(
                name: "IX_NguoiDung_MaNND",
                table: "NguoiDung",
                column: "MaNND");

            migrationBuilder.CreateIndex(
                name: "IX_NguoiDung_MaTG",
                table: "NguoiDung",
                column: "MaTG");

            migrationBuilder.CreateIndex(
                name: "IX_NguoiDungLop_MaLop",
                table: "NguoiDungLop",
                column: "MaLop");

            migrationBuilder.CreateIndex(
                name: "IX_TKB_MaLop",
                table: "TKB",
                column: "MaLop");

            migrationBuilder.CreateIndex(
                name: "IX_TKB_MaMH",
                table: "TKB",
                column: "MaMH");

            migrationBuilder.CreateIndex(
                name: "IX_TKB_MaNH",
                table: "TKB",
                column: "MaNH");

            migrationBuilder.CreateIndex(
                name: "IX_VaiTro_RoleId",
                table: "VaiTro",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_VaiTro_UserGroupId",
                table: "VaiTro",
                column: "UserGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BangDiem");

            migrationBuilder.DropTable(
                name: "ChucNang");

            migrationBuilder.DropTable(
                name: "NguoiDungLop");

            migrationBuilder.DropTable(
                name: "TKB");

            migrationBuilder.DropTable(
                name: "VaiTro");

            migrationBuilder.DropTable(
                name: "HanhKiem");

            migrationBuilder.DropTable(
                name: "HocLuc");

            migrationBuilder.DropTable(
                name: "NguoiDung");

            migrationBuilder.DropTable(
                name: "MonHoc");

            migrationBuilder.DropTable(
                name: "Quyen");

            migrationBuilder.DropTable(
                name: "GioiTinh");

            migrationBuilder.DropTable(
                name: "Lop");

            migrationBuilder.DropTable(
                name: "NhomNguoiDung");

            migrationBuilder.DropTable(
                name: "TonGiao");

            migrationBuilder.DropTable(
                name: "NamHoc");
        }
    }
}
