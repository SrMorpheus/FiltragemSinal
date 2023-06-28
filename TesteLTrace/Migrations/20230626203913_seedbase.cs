using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TesteLTrace.Migrations
{
    public partial class seedbase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ModelFiltros",
                columns: new[] { "Id", "HighPass", "LowPass" },
                values: new object[] { 1, 1.0, 1.0 });

            migrationBuilder.InsertData(
                table: "ModelGraficos",
                columns: new[] { "Id", "DadosSismico", "ModelFiltroId", "Tempo" },
                values: new object[,]
                {
                    { 1, 0.0014880200000000001, 1, 4000.0 },
                    { 2, -1.3063789999999999E-06, 1, 4000.0 },
                    { 3, 5.5409564000000002E-06, 1, 4000.0 },
                    { 4, 3.5207419999999999E-05, 1, 4000.0 },
                    { 5, 5.2020758E-05, 1, 4000.0 },
                    { 6, 6.0402551999999999E-05, 1, 4000.0 },
                    { 7, -4.3129519E-05, 1, 4000.0 },
                    { 8, -0.0001125016, 1, 4000.0 },
                    { 9, -0.00018260432, 1, 4000.0 },
                    { 10, -0.00015841763999999999, 1, 4000.0 },
                    { 11, -0.00011617896, 1, 4000.0 },
                    { 12, -0.00013290521999999999, 1, 4000.0 },
                    { 13, -0.00037435323000000001, 1, 4000.0 },
                    { 14, -0.00068153446999999999, 1, 4000.0 },
                    { 15, -0.00031832642999999998, 1, 4000.0 },
                    { 16, 0.00046329557999999997, 1, 4000.0 },
                    { 17, -0.00037943242999999998, 1, 4000.0 },
                    { 18, -0.0037876899999999998, 1, 4000.0 },
                    { 19, -0.0054747199999999998, 1, 4000.0 },
                    { 20, 0.00042749097000000002, 1, 4000.0 },
                    { 21, 0.01129542, 1, 4000.0 },
                    { 22, 0.01534481, 1, 4000.0 },
                    { 23, 0.0058036800000000003, 1, 4000.0 },
                    { 24, -0.0085639700000000006, 1, 4000.0 },
                    { 25, -0.01388226, 1, 4000.0 },
                    { 26, -0.0076128599999999999, 1, 4000.0 },
                    { 27, 0.0013743399999999999, 1, 4000.0 },
                    { 28, 0.0059568199999999998, 1, 4000.0 },
                    { 29, 0.0059667899999999996, 1, 4000.0 },
                    { 30, 0.0031811999999999999, 1, 4000.0 },
                    { 31, -0.00125056, 1, 4000.0 },
                    { 32, -0.0011019300000000001, 1, 4000.0 },
                    { 33, -0.0038094299999999999, 1, 4000.0 },
                    { 34, -0.0042684100000000003, 1, 4000.0 },
                    { 35, -0.00202688, 1, 4000.0 },
                    { 36, 0.0010157, 1, 4000.0 },
                    { 37, 0.0034266600000000002, 1, 4000.0 },
                    { 38, 0.0045318199999999998, 1, 4000.0 },
                    { 39, 0.0034148300000000002, 1, 4000.0 },
                    { 40, -9.0311965000000003E-05, 1, 4000.0 },
                    { 41, -0.0046695499999999997, 1, 4000.0 },
                    { 42, -0.0039939800000000003, 1, 4000.0 },
                    { 43, -0.00504003, 1, 4000.0 },
                    { 44, -0.0017662400000000001, 1, 4000.0 },
                    { 45, 0.0033193300000000001, 1, 4000.0 },
                    { 46, 0.0057649399999999996, 1, 4000.0 },
                    { 47, 0.0038215599999999999, 1, 4000.0 },
                    { 48, 0.0001423753, 1, 4000.0 },
                    { 49, -0.00211393, 1, 4000.0 },
                    { 50, -0.0025071899999999999, 1, 4000.0 },
                    { 51, -0.0039806800000000003, 1, 4000.0 },
                    { 52, -0.00185713, 1, 4000.0 },
                    { 53, -0.00013720396000000001, 1, 4000.0 },
                    { 54, 0.0023142900000000001, 1, 4000.0 },
                    { 55, 0.0034364500000000002, 1, 4000.0 },
                    { 56, 0.0015027599999999999, 1, 4000.0 },
                    { 57, -0.0021918200000000001, 1, 4000.0 },
                    { 58, -0.0039553599999999998, 1, 4000.0 },
                    { 59, -0.0017480799999999999, 1, 4000.0 },
                    { 60, 0.0020869299999999999, 1, 4000.0 },
                    { 61, -6.5110777000000004E-05, 1, 4000.0 },
                    { 62, 0.00311306, 1, 4000.0 },
                    { 63, 4.1200335999999998E-05, 1, 4000.0 },
                    { 64, -0.0046736299999999998, 1, 4000.0 },
                    { 65, -0.0037933400000000001, 1, 4000.0 },
                    { 66, -0.00218674, 1, 4000.0 },
                    { 67, 0.0041812200000000002, 1, 4000.0 },
                    { 68, 0.0046059899999999999, 1, 4000.0 },
                    { 69, 0.00209465, 1, 4000.0 },
                    { 70, -0.0021980699999999999, 1, 4000.0 },
                    { 71, 0.00263525, 1, 4000.0 },
                    { 72, -0.00469068, 1, 4000.0 },
                    { 73, -0.0021596800000000002, 1, 4000.0 },
                    { 76, 0.0035108100000000001, 1, 4000.0 },
                    { 78, 0.0061200100000000004, 1, 4000.0 },
                    { 79, 0.0031043199999999998, 1, 4000.0 },
                    { 80, -0.00089744007000000005, 1, 4000.0 },
                    { 81, 0.0013581699999999999, 1, 4000.0 },
                    { 82, 0.00038296446999999998, 1, 4000.0 },
                    { 83, -0.0023652399999999998, 1, 4000.0 },
                    { 84, -0.0079985999999999998, 1, 4000.0 },
                    { 85, -0.0087342099999999992, 1, 4000.0 },
                    { 86, -0.00056528149000000005, 1, 4000.0 },
                    { 87, 0.010557850000000001, 1, 4000.0 },
                    { 88, 0.01466104, 1, 4000.0 },
                    { 89, 0.0073115599999999999, 1, 4000.0 },
                    { 90, -0.0067625699999999999, 1, 4000.0 },
                    { 91, -0.0022255700000000001, 1, 4000.0 },
                    { 92, -0.017395770000000001, 1, 4000.0 },
                    { 93, -0.015960559999999999, 1, 4000.0 },
                    { 94, -0.0028647500000000001, 1, 4000.0 },
                    { 95, 0.01101428, 1, 4000.0 },
                    { 96, 0.01418228, 1, 4000.0 },
                    { 97, 0.00656275, 1, 4000.0 },
                    { 98, -0.00172098, 1, 4000.0 },
                    { 99, -0.0034644900000000002, 1, 4000.0 },
                    { 101, -0.0041904300000000002, 1, 4000.0 },
                    { 102, -0.00097349909000000003, 1, 4000.0 },
                    { 103, 0.00043476541999999999, 1, 4000.0 },
                    { 104, -0.00024356152999999999, 1, 4000.0 },
                    { 106, -0.00087278237000000005, 1, 4000.0 },
                    { 107, -0.00062934902999999996, 1, 4000.0 },
                    { 108, -0.00022400485, 1, 4000.0 },
                    { 109, -0.00018248211, 1, 4000.0 },
                    { 112, -0.00022873518, 1, 4000.0 },
                    { 113, -0.00019961090999999999, 1, 4000.0 },
                    { 114, -0.00019236178, 1, 4000.0 },
                    { 115, -0.00014879073, 1, 4000.0 },
                    { 116, -9.5523987999999996E-05, 1, 4000.0 },
                    { 117, -1.2213283000000001E-05, 1, 4000.0 },
                    { 118, 1.0215716999999999E-05, 1, 4000.0 },
                    { 201, -0.0025229800000000002, 1, 4000.0 },
                    { 301, 0.00150468, 1, 4000.0 },
                    { 401, 0.0042796900000000001, 1, 4000.0 },
                    { 501, 0.0034871699999999999, 1, 4000.0 },
                    { 601, 0.00047537008999999999, 1, 4000.0 },
                    { 701, -0.00111418, 1, 4000.0 },
                    { 801, -0.00012526485, 1, 4000.0 },
                    { 810, -0.00096810102999999995, 1, 4000.0 },
                    { 901, 0.00067645544000000004, 1, 4000.0 },
                    { 1010, -4.7469604000000002E-07, 1, 4000.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "ModelGraficos",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "ModelFiltros",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
