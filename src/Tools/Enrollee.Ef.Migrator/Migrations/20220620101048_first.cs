using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Enrollee.Ef.Migrator.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:uuid-ossp", ",,");

            migrationBuilder.CreateTable(
                name: "BaseModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    TypeEducationalInstitution = table.Column<string>(type: "text", nullable: true),
                    CharacterEducation = table.Column<string>(type: "text", nullable: true),
                    PlaceIdEducation = table.Column<int>(type: "integer", nullable: true),
                    MaritalStatusId = table.Column<Guid>(type: "uuid", nullable: true),
                    PassportDataId = table.Column<Guid>(type: "uuid", nullable: true),
                    EducationId = table.Column<Guid>(type: "uuid", nullable: true),
                    EntrantAddressId = table.Column<Guid>(type: "uuid", nullable: true),
                    DataOfBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    PlaceIdBirth = table.Column<int>(type: "integer", nullable: true),
                    VacancyId = table.Column<Guid>(type: "uuid", nullable: true),
                    Family = table.Column<int>(type: "integer", nullable: true),
                    BrotherSister = table.Column<int>(type: "integer", nullable: true),
                    Children = table.Column<int>(type: "integer", nullable: true),
                    NameNationality = table.Column<string>(type: "text", nullable: true),
                    Series = table.Column<int>(type: "integer", nullable: true),
                    Sex = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Surname = table.Column<string>(type: "text", nullable: true),
                    Patronomic = table.Column<string>(type: "text", nullable: true),
                    NationalityId = table.Column<Guid>(type: "uuid", nullable: true),
                    ItIsGiven = table.Column<bool>(type: "boolean", nullable: true),
                    DateEnd = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DateModification = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Country_Name = table.Column<string>(type: "text", nullable: true),
                    Destrict_Name = table.Column<string>(type: "text", nullable: true),
                    RegionId = table.Column<Guid>(type: "uuid", nullable: true),
                    Street = table.Column<string>(type: "text", nullable: true),
                    IsApartament = table.Column<bool>(type: "boolean", nullable: true),
                    IsHostel = table.Column<bool>(type: "boolean", nullable: true),
                    NumberHome = table.Column<int>(type: "integer", nullable: true),
                    Floor = table.Column<int>(type: "integer", nullable: true),
                    NumberApartament = table.Column<int>(type: "integer", nullable: true),
                    HomeTelethone = table.Column<int>(type: "integer", nullable: true),
                    CountryId = table.Column<Guid>(type: "uuid", nullable: true),
                    Place_Name = table.Column<string>(type: "text", nullable: true),
                    DestrictId = table.Column<Guid>(type: "uuid", nullable: true),
                    Region_Name = table.Column<string>(type: "text", nullable: true),
                    Region_CountryId = table.Column<Guid>(type: "uuid", nullable: true),
                    Login = table.Column<string>(type: "text", nullable: true),
                    Salt = table.Column<string>(type: "text", nullable: true),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    Role_Name = table.Column<string>(type: "text", nullable: true),
                    AccountId = table.Column<Guid>(type: "uuid", nullable: true),
                    Faculty_Name = table.Column<string>(type: "text", nullable: true),
                    ExternalId = table.Column<int>(type: "integer", nullable: true),
                    Language_Name = table.Column<string>(type: "text", nullable: true),
                    Language_ExternalId = table.Column<Guid>(type: "uuid", nullable: true),
                    Speciality_Name = table.Column<string>(type: "text", nullable: true),
                    Speciality_ExternalId = table.Column<Guid>(type: "uuid", nullable: true),
                    FacultyId = table.Column<Guid>(type: "uuid", nullable: true),
                    Forma = table.Column<int>(type: "integer", nullable: true),
                    Vacancy_ExternalId = table.Column<int>(type: "integer", nullable: true),
                    VacancyId1 = table.Column<int>(type: "integer", nullable: true),
                    SpecialityId = table.Column<Guid>(type: "uuid", nullable: true),
                    LanguageId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaseModel_BaseModel_AccountId",
                        column: x => x.AccountId,
                        principalTable: "BaseModel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BaseModel_BaseModel_CountryId",
                        column: x => x.CountryId,
                        principalTable: "BaseModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseModel_BaseModel_DestrictId",
                        column: x => x.DestrictId,
                        principalTable: "BaseModel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BaseModel_BaseModel_EducationId",
                        column: x => x.EducationId,
                        principalTable: "BaseModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseModel_BaseModel_EntrantAddressId",
                        column: x => x.EntrantAddressId,
                        principalTable: "BaseModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseModel_BaseModel_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "BaseModel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BaseModel_BaseModel_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "BaseModel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BaseModel_BaseModel_MaritalStatusId",
                        column: x => x.MaritalStatusId,
                        principalTable: "BaseModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseModel_BaseModel_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "BaseModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseModel_BaseModel_PassportDataId",
                        column: x => x.PassportDataId,
                        principalTable: "BaseModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseModel_BaseModel_Region_CountryId",
                        column: x => x.Region_CountryId,
                        principalTable: "BaseModel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BaseModel_BaseModel_RegionId",
                        column: x => x.RegionId,
                        principalTable: "BaseModel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BaseModel_BaseModel_SpecialityId",
                        column: x => x.SpecialityId,
                        principalTable: "BaseModel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BaseModel_BaseModel_VacancyId",
                        column: x => x.VacancyId,
                        principalTable: "BaseModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaseModel_AccountId",
                table: "BaseModel",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseModel_CountryId",
                table: "BaseModel",
                column: "CountryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BaseModel_DestrictId",
                table: "BaseModel",
                column: "DestrictId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseModel_EducationId",
                table: "BaseModel",
                column: "EducationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BaseModel_EntrantAddressId",
                table: "BaseModel",
                column: "EntrantAddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BaseModel_FacultyId",
                table: "BaseModel",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseModel_LanguageId",
                table: "BaseModel",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseModel_MaritalStatusId",
                table: "BaseModel",
                column: "MaritalStatusId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BaseModel_NationalityId",
                table: "BaseModel",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseModel_PassportDataId",
                table: "BaseModel",
                column: "PassportDataId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BaseModel_Region_CountryId",
                table: "BaseModel",
                column: "Region_CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseModel_RegionId",
                table: "BaseModel",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseModel_SpecialityId",
                table: "BaseModel",
                column: "SpecialityId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseModel_VacancyId",
                table: "BaseModel",
                column: "VacancyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaseModel");
        }
    }
}
