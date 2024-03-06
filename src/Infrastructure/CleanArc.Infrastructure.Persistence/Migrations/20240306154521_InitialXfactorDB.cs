using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialXfactorDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_TContacts_TIndividus_individuId",
                table: "TContacts");

            migrationBuilder.DropForeignKey(
                name: "FK_TRibs_TIndividus_individuId",
                table: "TRibs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TRibs",
                table: "TRibs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TIndividus",
                table: "TIndividus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TContacts",
                table: "TContacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "TRibs",
                newName: "TRib");

            migrationBuilder.RenameTable(
                name: "TIndividus",
                newName: "TIndividu");

            migrationBuilder.RenameTable(
                name: "TContacts",
                newName: "TContact");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameIndex(
                name: "IX_TRibs_individuId",
                table: "TRib",
                newName: "IX_TRib_individuId");

            migrationBuilder.RenameIndex(
                name: "IX_TContacts_individuId",
                table: "TContact",
                newName: "IX_TContact_individuId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UserId",
                table: "Order",
                newName: "IX_Order_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TRib",
                table: "TRib",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TIndividu",
                table: "TIndividu",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TContact",
                table: "TContact",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "T_AUTRE_F_RELELE",
                columns: table => new
                {
                    ID_AUTRE_F_REL = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REF_CTR_AUTRE_F_REL = table.Column<int>(type: "int", nullable: true),
                    ABEV_AUTRE_F_REL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MONT_AUTRE_F_REL = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    nom_ind_AUTRE_F_REL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DATE_AUTRE_F_REL = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_AUTRE_F_RELELE", x => x.ID_AUTRE_F_REL);
                });

            migrationBuilder.CreateTable(
                name: "T_BCT_RCM00",
                columns: table => new
                {
                    ID_RCM00 = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code_RCM00 = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: false),
                    C1_RCM00 = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    C2_RCM00 = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    C3_RCM00 = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    C4_RCM00 = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    C5_RCM00 = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    C6_RCM00 = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    C7_RCM00 = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    C8_RCM00 = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Date_RCM00 = table.Column<DateTime>(type: "date", nullable: false),
                    Valide_RCM00 = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "T_BORD_FACTOR",
                columns: table => new
                {
                    ID_BORD_FACTOR = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NUM_BORD_FACTOR = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ID_FACTOR_BORD_FACTOR = table.Column<int>(type: "int", nullable: true),
                    REF_CTR_BORD_FACTOR = table.Column<int>(type: "int", nullable: false),
                    MONT_TOT_BORD_FACTOR = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    DAT_CRE_BORD_FACTOR = table.Column<DateTime>(type: "date", nullable: true),
                    DAT_EDIT_BORD_FACTOR = table.Column<DateTime>(type: "date", nullable: true),
                    VALID_BORD_FACTOR = table.Column<bool>(type: "bit", nullable: false),
                    ID_ENC_BORD_FACTOR = table.Column<int>(type: "int", nullable: true),
                    REF_ENC_BORD_FACTOR = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_BORD_FACTOR", x => x.ID_BORD_FACTOR);
                });

            migrationBuilder.CreateTable(
                name: "T_BORD_MFG",
                columns: table => new
                {
                    ID_BORD_MFG = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REF_CTR_BORD_MFG = table.Column<int>(type: "int", nullable: true),
                    REF_ADH_BORD_MFG = table.Column<int>(type: "int", nullable: true),
                    NOM_ADH_BORD_MFG = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    NUM_BORD_MFG = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    MNT_COMM_HT_BORD_MFG = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    DATE_BORD_MFG = table.Column<DateTime>(type: "date", nullable: true),
                    DATE_ENVOIE_BORD_MFG = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "T_BORDEREAU",
                columns: table => new
                {
                    NUM_BORD = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    REF_CTR_BORD = table.Column<int>(type: "int", nullable: false),
                    ANNEE_BORD = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    REF_ADH_BORD = table.Column<int>(type: "int", nullable: true),
                    REF_ACH_BORD = table.Column<int>(type: "int", nullable: true),
                    DAT_BORD = table.Column<DateTime>(type: "date", nullable: true),
                    NB_DOC_BORD = table.Column<short>(type: "smallint", nullable: true),
                    MONT_TOT_BORD = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    DEVISE_ACH = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: true),
                    SOLDE_BORD = table.Column<bool>(type: "bit", nullable: true),
                    VALIDE_BORD = table.Column<bool>(type: "bit", nullable: true),
                    DAT_SAISIE_BORD = table.Column<DateTime>(type: "date", nullable: true),
                    EMETTEUR = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__T_BORDER__3DDB9DEBA9209E94", x => new { x.NUM_BORD, x.REF_CTR_BORD, x.ANNEE_BORD });
                });

            migrationBuilder.CreateTable(
                name: "T_Bordereau_MFG",
                columns: table => new
                {
                    ID_Bord_MFG = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type_MFG = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Ref_ADH_MFG = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Ref_ACH_MFG = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Num_Bord_MFG = table.Column<int>(type: "int", nullable: true),
                    Ref_Doc_MFG = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Date_Bord_MFG = table.Column<DateTime>(type: "date", nullable: true),
                    MONT_TTC_DET_MFG = table.Column<decimal>(type: "numeric(18,3)", nullable: true),
                    Compte_MFG = table.Column<int>(type: "int", nullable: true),
                    MONT_FDG_DET_MFG = table.Column<decimal>(type: "numeric(18,3)", nullable: true),
                    acc_fourn_adh_MFG = table.Column<decimal>(type: "numeric(18,3)", nullable: true),
                    Mnt_Finanancement_MFG = table.Column<decimal>(type: "numeric(18,3)", nullable: true),
                    Date_Creation_MFG = table.Column<DateTime>(type: "date", nullable: true),
                    Date_Envoie_MFG = table.Column<DateTime>(type: "date", nullable: true),
                    Flag_MFG = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "T_CALC_DISPO",
                columns: table => new
                {
                    ID_CALC_DISPO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DATE__CALC_DISPO = table.Column<DateTime>(type: "date", nullable: true),
                    DISPO_CALC_DISPO = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    REF_ADH_CALC_DISPO = table.Column<int>(type: "int", nullable: true),
                    REF_CTR_CALC_DISPO = table.Column<int>(type: "int", nullable: true),
                    SOM_FACT_CALC_DISPO = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    SOM_AVOIR_CALC_DISPO = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    SOM_COMM_FACTOR_CALC_DISPO = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    SOM_TVA_COMM_FATOR_CALC_DISPO = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    SOM_DEBIT_CALC_DISPO = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    SOM_CREDIT_CALC_DISPO = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    SOM_FDG_FACT_CALC_DISPO = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    SOM_FDG_LIBERE_CALC_DISPO = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    FINANCE_CALC_DISPO = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    INTERET_J_CALC_DISPO = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    MARGE_J_CALC_DISPO = table.Column<decimal>(type: "decimal(6,4)", nullable: true),
                    TMM_J_CALC_DISPO = table.Column<decimal>(type: "decimal(6,4)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "T_CALC_INT_IR",
                columns: table => new
                {
                    ID_CALC_IR = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REF_CTR_CALC_IR = table.Column<int>(type: "int", nullable: true),
                    REF_DOCUMENT_DET_BORD_IR = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    MONT_OUV_DET_BORD_IR = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Date_Echeance_IR = table.Column<DateTime>(type: "date", nullable: true),
                    MAJOR_INT_INT_FIN_IR = table.Column<int>(type: "int", nullable: true),
                    MONT_CALC_IR = table.Column<decimal>(type: "decimal(15,3)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "T_COMM_FACTORING",
                columns: table => new
                {
                    TYP_COMM_FACTORING = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    REF_CTR_COMM_FACTORING = table.Column<int>(type: "int", nullable: false),
                    TX_COMM_FACTORING = table.Column<decimal>(type: "decimal(5,3)", nullable: true),
                    MONT_MIN_DOC_COMM_FACTORING = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    MONT_MIN_CTR_COMM_FACTORING = table.Column<decimal>(type: "decimal(15,3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__T_COMM_F__C4A21010206A2EA6", x => new { x.TYP_COMM_FACTORING, x.REF_CTR_COMM_FACTORING });
                });

            migrationBuilder.CreateTable(
                name: "T_Comm_MFG",
                columns: table => new
                {
                    Id_MFG = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type_MFG = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Ref_ADH_MFG = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Code_MFG = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Mnt_Comm_MFG = table.Column<decimal>(type: "numeric(18,3)", nullable: true),
                    Num_Bord_MFG = table.Column<int>(type: "int", nullable: true),
                    date_Saisie_MFG = table.Column<DateTime>(type: "date", nullable: true),
                    Date_Envoie_MFG = table.Column<DateTime>(type: "date", nullable: true),
                    Flag_MFG = table.Column<bool>(type: "bit", nullable: true),
                    Type_Action_MFG = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "T_COMM_RELEVE",
                columns: table => new
                {
                    ID_COMM_RAP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REF_CTR_COMM_RAP = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DAT_BORD_COMM_RAP = table.Column<DateTime>(type: "date", nullable: true),
                    num_bord_COMM_RAP = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    MONT_COMM_HT_COMM_RAP = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    TVA_COMM_RAP = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    MONT_COMM_TVA_COMM_RAP = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    MONT_COMM_TTC_COMM_RAP = table.Column<decimal>(type: "decimal(15,3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_COMM_RELEVE", x => x.ID_COMM_RAP);
                });

            migrationBuilder.CreateTable(
                name: "T_COMMENT",
                columns: table => new
                {
                    ID_COMMENT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ACTION = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    COMMENT = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    DATE_COMMENT = table.Column<DateTime>(type: "date", nullable: false),
                    DATE_TRAITE_COMMENT = table.Column<DateTime>(type: "date", nullable: true),
                    VALIDATION_TYPE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    IS_RESOLVED = table.Column<bool>(type: "bit", nullable: false),
                    ID_ACTION = table.Column<int>(type: "int", nullable: false),
                    REF_CTR_ACTION = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_COMMENT", x => x.ID_COMMENT);
                });

            migrationBuilder.CreateTable(
                name: "T_COMPTE",
                columns: table => new
                {
                    ID_COMPT = table.Column<int>(type: "int", nullable: false),
                    ID_CIR = table.Column<int>(type: "int", nullable: false),
                    DEVISE_ACH_CPT = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: true),
                    LIM_FIN_ACH_ADH = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    DELAI_PAI_CPT = table.Column<short>(type: "smallint", nullable: true),
                    MODE_REG_CPT = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TOT_FACT_CPT = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    FDG_REL_FACT_CPT = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    DEPASS_LIM_CPT = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    TOT_LIT_CPT = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    TOT_IMP_CPT = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    DAT_CPT = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_COMPTE", x => new { x.ID_COMPT, x.ID_CIR });
                });

            migrationBuilder.CreateTable(
                name: "T_CONFIGURATION_EMAIL",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_FACTOR = table.Column<int>(type: "int", nullable: true),
                    EMAIL = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    MDP = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    SMTP = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    PORT = table.Column<int>(type: "int", nullable: true),
                    EnableSsl = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_CONFIGURATION_EMAIL", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "T_CONTACT",
                columns: table => new
                {
                    ID_CONTACT = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REF_IND_CONTACT = table.Column<int>(type: "int", nullable: false),
                    NOM_PRE_CONTACT = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    POS_CONTACT = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TEL1_CONTACT = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    TEL2_CONTACT = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    MAIL1_COONTACT = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    MAIL2_COONTACT = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    FAX_CONTACT = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    ACTIF_CONTACT = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__T_CONTAC__D7288A5A1844C16F", x => x.ID_CONTACT);
                });

            migrationBuilder.CreateTable(
                name: "T_CONTACT_FACTOR",
                columns: table => new
                {
                    ID_CONTACT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REF_IND_CONTACT = table.Column<int>(type: "int", nullable: true),
                    NOM_PRE_CONTACT = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    POS_CONTACT = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TEL1_CONTACT = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TEL2_CONTACT = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    MAIL1_CONTACT = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    MAIL2_CONTACT = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    FAX_CONTACT = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ACTIF_CONTACT = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_CONTACT_FACTOR", x => x.ID_CONTACT);
                });

            migrationBuilder.CreateTable(
                name: "T_CONTRAT",
                columns: table => new
                {
                    REF_CTR = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    STATUT_CTR = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    REF_CTR_PAPIER_CTR = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    SERVICE_CTR = table.Column<bool>(type: "bit", nullable: true),
                    TYP_CTR = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true),
                    DAT_SIGN_CTR = table.Column<DateTime>(type: "date", nullable: true),
                    DAT_DEB_CTR = table.Column<DateTime>(type: "date", nullable: true),
                    DAT_RESIL_CTR = table.Column<DateTime>(type: "date", nullable: true),
                    DAT_PROCH_VERS_CTR = table.Column<DateTime>(type: "date", nullable: true),
                    CA_CTR = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    CA_EXP_CTR = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    CA_IMP_CTR = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    LIM_FIN_CTR = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    DEVISE_CTR = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: true),
                    NB_ACH_PREVU_CTR = table.Column<short>(type: "smallint", nullable: true),
                    NB_FACT_PREVU_CTR = table.Column<short>(type: "smallint", nullable: true),
                    NB_AVOIRS_PREVU_CTR = table.Column<short>(type: "smallint", nullable: true),
                    NB_REMISES_PREVU_CTR = table.Column<short>(type: "smallint", nullable: true),
                    DELAI_MOYEN_REG_CTR = table.Column<short>(type: "smallint", nullable: true),
                    DELAI_MAX_REG_CTR = table.Column<short>(type: "smallint", nullable: true),
                    FACT_REG_CTR = table.Column<bool>(type: "bit", nullable: true),
                    DERN_MONT_DISP_2 = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    MIN_COMM_FACT = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    IS_NOTIFIED = table.Column<bool>(type: "bit", nullable: true),
                    OLD_STATUT_CTR = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DAT_CREATION_CTR = table.Column<DateTime>(type: "date", nullable: true),
                    RESP_CTR_1 = table.Column<int>(type: "int", nullable: true),
                    RESP_CTR_2 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__T_CONTRA__C374064F18EBB532", x => x.REF_CTR);
                });

            migrationBuilder.CreateTable(
                name: "T_DEM_FIN_CREDIT",
                columns: table => new
                {
                    ID_DEM_FIN_CREDIT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CIR_DEM = table.Column<int>(type: "int", nullable: false),
                    MONT_FIN_DEM = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    MONT_FIN_ACC = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    DAT_FIN_ACC = table.Column<DateTime>(type: "date", nullable: true),
                    MONT_CREDIT_DEM = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    MONT_CREDIT_ACC = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    DAT_CREDIT_ACC = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__T_DEM_FI__0B18FF0A093F5D4E", x => x.ID_DEM_FIN_CREDIT);
                });

            migrationBuilder.CreateTable(
                name: "T_DEM_LIMITE",
                columns: table => new
                {
                    REF_DEM_LIM = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REF_CTR_DEM_LIM = table.Column<int>(type: "int", nullable: false),
                    TYP_DEM_LIM = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    DAT_DEM_LIM = table.Column<DateTime>(type: "date", nullable: false),
                    SORT_DEM_LIM = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    MONT_DEM_LIM = table.Column<decimal>(type: "decimal(17,3)", nullable: true),
                    DEVISE = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: true),
                    DAT_LAST_DEM_LIM = table.Column<DateTime>(type: "date", nullable: true),
                    DECISION_LIM = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true),
                    MONT_ACC = table.Column<decimal>(type: "decimal(17,3)", nullable: true),
                    MONT_LIM_ACH_ADH = table.Column<decimal>(type: "decimal(17,3)", nullable: true),
                    DAT_ANNUL_DEM_LIM = table.Column<DateTime>(type: "date", nullable: true),
                    DATLIM_DEM_LIM = table.Column<DateTime>(type: "date", nullable: true),
                    DELAIS_DEM_LIM = table.Column<short>(type: "smallint", nullable: true),
                    DELAIS_ACC = table.Column<short>(type: "smallint", nullable: true),
                    MODE_PAY_DEM_LIM = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    MODE_PAY_ACC = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ACTIF_DEM_LIMI = table.Column<bool>(type: "bit", nullable: true),
                    REF_ACH_LIM = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_DEM_LIMITE_1", x => new { x.REF_DEM_LIM, x.REF_CTR_DEM_LIM });
                });

            migrationBuilder.CreateTable(
                name: "T_Det_Achat_RELEVE",
                columns: table => new
                {
                    ID_Det_Achat_REL = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom_ind_Det_Achat_REL = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    REF_CTR_Det_Achat_REL = table.Column<int>(type: "int", nullable: true),
                    TYP_DET_BORD_Det_Achat_REL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    num_bord_Det_Achat_REL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ref_document_Det_Achat_REL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MONT_TTC_Det_Achat_REL = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    DAT_DET_BORD_Det_Achat_REL = table.Column<DateTime>(type: "date", nullable: true),
                    DAT_ECHEANCE_Det_Achat_REL = table.Column<DateTime>(type: "date", nullable: true),
                    MONT_TTC_COMM_Det_Achat_REL = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    TX_COMM_Det_Achat_REL = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    DAT_BORD_Det_Achat_REL = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Det_Achat_RELEVE", x => x.ID_Det_Achat_REL);
                });

            migrationBuilder.CreateTable(
                name: "T_DET_ASS",
                columns: table => new
                {
                    REF_ASS = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REF_CTR_ASS = table.Column<int>(type: "int", nullable: true),
                    PRIME_ASS = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    TX_COUVERTURE_ASS = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    DELAIS_DECALARATION_SINISTRE_ASS = table.Column<int>(type: "int", nullable: true),
                    ACTIF_ASS = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_DET_ASS", x => x.REF_ASS);
                });

            migrationBuilder.CreateTable(
                name: "T_DOC_GED",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_IND_GED = table.Column<int>(type: "int", nullable: true),
                    ID_CTR_GED = table.Column<int>(type: "int", nullable: true),
                    ID_BOR_GED = table.Column<int>(type: "int", nullable: true),
                    ID_DET_BORD_GED = table.Column<int>(type: "int", nullable: true),
                    ID_ENC_GED = table.Column<int>(type: "int", nullable: true),
                    ID_DEBIT_GED = table.Column<int>(type: "int", nullable: true),
                    ID_CREDIT_GED = table.Column<int>(type: "int", nullable: true),
                    ID_FINCANEMENT_GED = table.Column<int>(type: "int", nullable: true),
                    ANNEE_BORD_GED = table.Column<int>(type: "int", nullable: true),
                    LIBELLE_GED = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DATE_TACHE_GED = table.Column<DateTime>(type: "datetime", nullable: false),
                    ID_GESTIONNAIRE_GED = table.Column<int>(type: "int", nullable: true),
                    DATE_SCAN_GED = table.Column<DateTime>(type: "datetime", nullable: true),
                    ADRESS_DOC_GED = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    Data_GED = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Name_GED = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    salle_GED = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Armoire_GED = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Etgage_GED = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Archive_GED = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LIBELLE2_GED = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    ID_Emetteur_GED = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Etape_ged = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Etat_GED = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_DOC_GED", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "T_DOC_PHYSIQUE",
                columns: table => new
                {
                    TYP_DOC_PHY = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    REF_CTR_DOC_PHY = table.Column<int>(type: "int", nullable: false),
                    DAT_VALID_DOC_PHY = table.Column<DateTime>(type: "date", nullable: true),
                    DAT_EXPIR_DOC_PHY = table.Column<DateTime>(type: "date", nullable: true),
                    DOC_BLOQ_DOC_PHY = table.Column<bool>(type: "bit", nullable: true),
                    REF_USER_DOC_PHY = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    DOC_RECU_DOC_PHY = table.Column<bool>(type: "bit", nullable: true),
                    IS_SENT = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__T_DOC_PH__47E98F6E7A3223E8", x => new { x.TYP_DOC_PHY, x.REF_CTR_DOC_PHY });
                });

            migrationBuilder.CreateTable(
                name: "T_EC_COMPTABLE",
                columns: table => new
                {
                    ID_EC_CPT = table.Column<int>(type: "int", nullable: false),
                    TYP_TR_EC_CPT = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    DAT_SAIS_EC_CPT = table.Column<DateTime>(type: "date", nullable: true),
                    DAT_EFF_EC_CPT = table.Column<DateTime>(type: "date", nullable: true),
                    MONT_EC_CPT = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    REF_EC_CPT = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: true),
                    DESC_EC_CPT = table.Column<string>(type: "varchar(70)", unicode: false, maxLength: 70, nullable: true),
                    ID_USER_EC_EPT = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    LOT_EC_CPT = table.Column<string>(type: "nchar(8)", fixedLength: true, maxLength: 8, nullable: true),
                    DEVISE_EC_CPT = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    CODE_ENT_EC_CPT = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    LIGNE_EC_CPT = table.Column<long>(type: "bigint", nullable: true),
                    REF_ADH_EC_CPT = table.Column<int>(type: "int", nullable: true),
                    TYP_DOC_EC_CPT = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    COD_JOURNAL_EC_CPT = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    SEQ_COD_JOURNAL_EC_CPT = table.Column<string>(type: "nchar(9)", fixedLength: true, maxLength: 9, nullable: true),
                    DECS_SRC_CG_EC_CPT = table.Column<string>(type: "varchar(32)", unicode: false, maxLength: 32, nullable: true),
                    DOMAINE_EC_CPT = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "T_EC_CPT",
                columns: table => new
                {
                    ID_ECCPT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_EC_CPT = table.Column<int>(type: "int", nullable: false),
                    ANNEE_EC_CPT = table.Column<int>(type: "int", nullable: true),
                    CODE_DEP_EC_CPT = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NUM_EC_EC_CPT = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    NUM_LIGNE_EC_CPT = table.Column<byte>(type: "tinyint", nullable: true),
                    CODE_JOURNAL_EC_CPT = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    DATE_SAISIE_EC_CPT = table.Column<DateTime>(type: "date", nullable: true),
                    DATE_EFFET_EC_CPT = table.Column<DateTime>(type: "date", nullable: true),
                    LIBELLEE_EC_CPT = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    COMPTE_GEN_EC_CPT = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MONTANT_EC_CPT = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    CODE_CENTRE_ANALYSE_EC_CPT = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    REF_PIECE_EC_CPT = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TYPE_TRANSACTION_EC_CPT = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    TYPE_DOC_EC_CPT = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    NOM_USER_EC_CPT = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LOT_EC_CPT = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CODE_TIERS_EC_CPT = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    DOMAINE_EC_CPT = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CREDIT_EC_CPT = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    DATE_EC_CPT = table.Column<DateTime>(type: "date", nullable: true),
                    REF_ADH_EC_CPT = table.Column<int>(type: "int", nullable: true),
                    COMPTE_EC_CPT = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CODE_EC_CPT = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    INTITULE_EC_CPT = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    REF_MFG_ADH_EC_CPT = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_EC_CPT", x => x.ID_ECCPT);
                });

            migrationBuilder.CreateTable(
                name: "T_EMAIL",
                columns: table => new
                {
                    ID_USER = table.Column<int>(type: "int", nullable: false),
                    TITRE_GROUPE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ID_EMAIL = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_EMAIL", x => new { x.ID_USER, x.TITRE_GROUPE });
                });

            migrationBuilder.CreateTable(
                name: "T_ENCAISSEMENT",
                columns: table => new
                {
                    ID_ENC = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REF_CTR_ENC = table.Column<int>(type: "int", nullable: false),
                    REF_ADH_ENC = table.Column<int>(type: "int", nullable: true),
                    REF_ACH_ENC = table.Column<int>(type: "int", nullable: true),
                    MONT_ENC = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    DEVISE_ENC = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: true),
                    DAT_RECEP_ENC = table.Column<DateTime>(type: "date", nullable: true),
                    DAT_VAL_ENC = table.Column<DateTime>(type: "date", nullable: true),
                    TYP_ENC = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    VALIDE_ENC = table.Column<bool>(type: "bit", nullable: true),
                    REF_ENC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    RIB_ENC = table.Column<string>(type: "nchar(30)", fixedLength: true, maxLength: 30, nullable: true),
                    BORD_ENC = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    REF_SEQ_ENC = table.Column<string>(type: "varchar(9)", unicode: false, maxLength: 9, nullable: true),
                    PREAVIS = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__T_ENCAIS__2D4C367D67DE6983", x => x.ID_ENC);
                });

            migrationBuilder.CreateTable(
                name: "T_ETAT_DISPO",
                columns: table => new
                {
                    ID_ETAT_DISPO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ref_Ctr__ETAT_DISPO = table.Column<int>(type: "int", nullable: true),
                    Total_Facture_ETAT_DISPO = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Total_Fin_ETAT_DISPO = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Total_Av_ETAT_DISPO = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Total_Comm_ETAT_DISPO = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Total_Frais_ETAT_DISPO = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Total_Debit_ETAT_DISPO = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Total_Credit_ETAT_DISPO = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Total_Interet_ETAT_DISPO = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Depass_Limite_ETAT_DISPO = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Total_Retenue_ETAT_DISPO = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Total_FDG_ETAT_DISPO = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Disponible_ETAT_DISPO = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Date_ETAT_DISPO = table.Column<DateTime>(type: "date", nullable: true),
                    Total_Encours_Facture_ETAT_DISPO = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Total_IR_ETAT_DIPOS = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Total_Instru_Paiments_Imp_ETAT_DIPOS = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Total_Retard_Paiement_Algo_ETAT_DISPO = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Total_Litiges_ouvert_ETAT_DISPO = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Total_Disponible_2_ETAT_DISPO = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Total_Fonds_Reserve_ETAT_DISPO = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Total_Financement_du_mois_ETAT_DISPO = table.Column<decimal>(type: "decimal(15,3)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "T_EXTRAIT",
                columns: table => new
                {
                    ID_EXTRAIT = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REF_CTR_EXTRAIT = table.Column<int>(type: "int", nullable: true),
                    LIB_EXTRAIT = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    DAT_OP_EXTRAIT = table.Column<DateTime>(type: "datetime", nullable: true),
                    DAT_VAL_EXTRAIT = table.Column<DateTime>(type: "datetime", nullable: true),
                    DEBIT_EXTRAIT = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    CREDIT_EXTRAIT = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    ENCOURFACT_EXTRAIT = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    TOTAL_FIN_EXTRAIT = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    DISPONIBLE_EXTRAIT = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    FDG_EXTRAIT = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    AUTRE_EXTRAIT = table.Column<decimal>(type: "decimal(15,3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_EXTRAIT", x => x.ID_EXTRAIT);
                });

            migrationBuilder.CreateTable(
                name: "T_FACTOR",
                columns: table => new
                {
                    ID_FACTOR = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RAISON_SOCIAL = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    ABRV = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RC = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    MF = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CODE_TVA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CODE_DOUANE = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ADRESSE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CAPITAL = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CAPITAL_LETTRE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    LOGO_16 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    LOGO_32 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    LOGO_48 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    EMAIL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TEL = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FAX = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    SITE_WEB = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EXERCICE = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    DEVISE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LANGUE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PAYS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SRV_DB = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DB = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CNX_DB = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MDP_CNX = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Det_Doc_GED = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_FACTOR", x => x.ID_FACTOR);
                });

            migrationBuilder.CreateTable(
                name: "T_Fichiers_Scan",
                columns: table => new
                {
                    Id_Scan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom_Fichier_Scan = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Date_Scan = table.Column<DateTime>(type: "date", nullable: true),
                    Adresse_Scan = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Affect_Scan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Nom_Fichier_SansEXT = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "T_FINANCEMENT",
                columns: table => new
                {
                    ID_FIN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REF_CTR_FIN = table.Column<int>(type: "int", nullable: true),
                    REF_ADH_FIN = table.Column<int>(type: "int", nullable: true),
                    MONT_FIN = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    DAT_FIN = table.Column<DateTime>(type: "date", nullable: true),
                    INSTR_FIN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    REF_INSTR_FIN = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    DAT_INSTR_FIN = table.Column<DateTime>(type: "date", nullable: true),
                    ETAT_FIN = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ID_DISPO_FIN = table.Column<int>(type: "int", nullable: true),
                    TYPE_ENC = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_FINANCEMENT_5", x => x.ID_FIN);
                });

            migrationBuilder.CreateTable(
                name: "T_FOND_GARANTIE",
                columns: table => new
                {
                    TYP_FDG = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    REF_CTR_FDG = table.Column<int>(type: "int", nullable: false),
                    LIB_FDG = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TX_FDG = table.Column<decimal>(type: "decimal(5,3)", nullable: true),
                    MONT_MAX_FDG = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    MONT_MIN_FDG = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    TYP_DOC_REMIS_FDG = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__T_FOND_G__CD7BEB41B71B42C1", x => new { x.REF_CTR_FDG, x.TYP_FDG });
                });

            migrationBuilder.CreateTable(
                name: "T_FRAIS_DIVERS",
                columns: table => new
                {
                    TYP_FRAIS_DIVERS = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    REF_CTR_FRAIS_DIVERS = table.Column<int>(type: "int", nullable: false),
                    MONT_PAR_UNIT_FRAIS_DIVERS = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    LIB_FRAIS_DIVERS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__T_FRAIS___B72D5284465B0E76", x => new { x.TYP_FRAIS_DIVERS, x.REF_CTR_FRAIS_DIVERS });
                });

            migrationBuilder.CreateTable(
                name: "T_FRAIS_PAIEMENT",
                columns: table => new
                {
                    TYP_FRAIS_PAIE = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    REF_CTR_FRAIS_PAIE = table.Column<int>(type: "int", nullable: false),
                    MONT_PAR_INSTR_FRAIS_PAIE = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    LIB_FRAIS_PAIE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__T_FRAIS___D572DF09CAE41C88", x => new { x.TYP_FRAIS_PAIE, x.REF_CTR_FRAIS_PAIE });
                });

            migrationBuilder.CreateTable(
                name: "T_FRAIS_RELEVE",
                columns: table => new
                {
                    ID_FRAIS_REL = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REF_CTR_ = table.Column<int>(type: "int", nullable: true),
                    dat_recep_enc = table.Column<DateTime>(type: "date", nullable: true),
                    typ_enc = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Nb_piéce = table.Column<int>(type: "int", nullable: true),
                    MONT_PAR_INSTR_FRAIS_PAIE = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    TVA = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    TAXTVA = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    TTCPP = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    MNTTTCT = table.Column<decimal>(type: "decimal(15,3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_FRAIS_RELEVE", x => x.ID_FRAIS_REL);
                });

            migrationBuilder.CreateTable(
                name: "T_GROUPE",
                columns: table => new
                {
                    ID_GROUP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REF_IND_GROUP = table.Column<int>(type: "int", nullable: true),
                    NOM_GROUP = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_GROUPE", x => x.ID_GROUP);
                });

            migrationBuilder.CreateTable(
                name: "T_HISTORIQUE",
                columns: table => new
                {
                    ID_HISTORIQUEE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_HISTORIQUE = table.Column<int>(type: "int", nullable: false),
                    DATE_ACTION = table.Column<DateTime>(type: "datetime", nullable: true),
                    ACTION = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    T_TABLE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ID_ENREGISTREMENT = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    LOGIN_USER = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IP_PC = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NOM_PC = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    REF_CTR_HIST = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    REF_IND_HIST = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ABREV_ROLE_HIST = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_HISTORIQUE", x => x.ID_HISTORIQUEE);
                });

            migrationBuilder.CreateTable(
                name: "T_IMPAYE",
                columns: table => new
                {
                    ID_IMP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_ENC_IMP = table.Column<int>(type: "int", nullable: false),
                    ID_DET_BORD_IMP = table.Column<int>(type: "int", nullable: true),
                    DATE_IMP = table.Column<DateTime>(type: "date", nullable: true),
                    DATE_SAISI_IMP = table.Column<DateTime>(type: "date", nullable: true),
                    MONT_IMP = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    DATE_RESOL_IMP = table.Column<DateTime>(type: "date", nullable: true),
                    ID_NV_ENCS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    IS_RESOLU = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_IMPAYE", x => x.ID_IMP);
                });

            migrationBuilder.CreateTable(
                name: "T_INDIVIDU",
                columns: table => new
                {
                    REF_IND = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GENRE_IND = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true),
                    TYP_DOC_ID_IND = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    NUM_DOC_ID_IND = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LIEU_DOC_ID_IND = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATE_DOC_ID_IND = table.Column<DateTime>(type: "date", nullable: true),
                    COD_TVA_IND = table.Column<string>(type: "char(20)", unicode: false, fixedLength: true, maxLength: 20, nullable: true),
                    NOM_IND = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    PRE_IND = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DAT_NAISS_CREAT = table.Column<DateTime>(type: "date", nullable: true),
                    GRP_IND = table.Column<bool>(type: "bit", nullable: true),
                    LIM_CRED_GLO_IND = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    LIM_FIN_GLO_IND = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    INFO_IND = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    DAT_INFO_IND = table.Column<DateTime>(type: "date", nullable: true),
                    ID_NLDP = table.Column<int>(type: "int", nullable: true),
                    COD_SCLAS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ABRV_IND = table.Column<string>(type: "char(20)", unicode: false, fixedLength: true, maxLength: 20, nullable: true),
                    LOGO_IND = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PHOTO_IND = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    MF_IND = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    RC_IND = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EXO_TVA = table.Column<bool>(type: "bit", nullable: true),
                    DAT_DEB_EXO = table.Column<DateTime>(type: "date", nullable: true),
                    DAT_FIN_EXO = table.Column<DateTime>(type: "date", nullable: true),
                    TEL_IND = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FAX_IND = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EMAIL_IND = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    REF_ADH_IND = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    FROM_JUR_IND = table.Column<string>(type: "nchar(100)", fixedLength: true, maxLength: 100, nullable: true),
                    EXO_IND = table.Column<bool>(type: "bit", nullable: true),
                    ADR_IND = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CP_IND = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    REF_ACH_IND = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    ID_GROUPE = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__T_INDIVI__C2FC383A7073AF84", x => x.REF_IND);
                });

            migrationBuilder.CreateTable(
                name: "T_INFO_CTR",
                columns: table => new
                {
                    ID_INFO_CTR = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REF_INFO_CTR = table.Column<int>(type: "int", nullable: true),
                    LIBELLE_INFO_CTR = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DATE_INFO_CTR = table.Column<DateTime>(type: "date", nullable: true),
                    ID_USER_INFO_CTR = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_INFO_CTR", x => x.ID_INFO_CTR);
                });

            migrationBuilder.CreateTable(
                name: "T_INT_FINANCEMENT",
                columns: table => new
                {
                    TYP_INSTR_INT_FIN = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    REF_CTR_INT_FIN = table.Column<int>(type: "int", nullable: false),
                    TX_INT_MARCHE_INT_FIN = table.Column<decimal>(type: "decimal(5,3)", nullable: true),
                    TX_MARGE_CTR_INT_FIN = table.Column<decimal>(type: "decimal(5,3)", nullable: true),
                    DELAI_MAX_PAI_INT_FIN = table.Column<short>(type: "smallint", nullable: true),
                    PRECOMPTE_INT_FIN = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    MAJOR_INT_INT_FIN = table.Column<decimal>(type: "decimal(5,3)", nullable: true),
                    DAT_DEB_VALID_INT_FIN = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__T_INT_FI__BEC6666211EF5D1D", x => new { x.TYP_INSTR_INT_FIN, x.REF_CTR_INT_FIN });
                });

            migrationBuilder.CreateTable(
                name: "T_LITIGE",
                columns: table => new
                {
                    ID_LITIGE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TYP_LIT = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    REF_CTR_LIT = table.Column<int>(type: "int", nullable: false),
                    DAT_LIT = table.Column<DateTime>(type: "date", nullable: true),
                    ECH_LIT = table.Column<DateTime>(type: "date", nullable: true),
                    MONT_LT = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    ETAT_LIT = table.Column<bool>(type: "bit", nullable: true),
                    ID_DET_BORD_LIT = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__T_LITIGE__66F660A1412EB0B6", x => x.ID_LITIGE);
                });

            migrationBuilder.CreateTable(
                name: "T_MOTIF_LIT",
                columns: table => new
                {
                    REF_CTR_MOTIF_LIT = table.Column<int>(type: "int", nullable: false),
                    TYP_MOTIF_LIT = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    LIB_MOTIF_LIT = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DELAI_RESOL_MOTIF_LIT = table.Column<short>(type: "smallint", nullable: true),
                    RETRO_AUTO_MOTIF_LIT = table.Column<bool>(type: "bit", nullable: true),
                    ALERTE_LIT_MOTIF_LIT = table.Column<bool>(type: "bit", nullable: true),
                    FRAIS_MOTIF_LIT = table.Column<bool>(type: "bit", nullable: true),
                    LOGIN_USER_MOTIF_LIT = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__T_MOTIF___CA7DAB520D44F85C", x => new { x.REF_CTR_MOTIF_LIT, x.TYP_MOTIF_LIT });
                });

            migrationBuilder.CreateTable(
                name: "T_MOTIF_PROG",
                columns: table => new
                {
                    REF_CTR_MOTIF_PROG = table.Column<int>(type: "int", nullable: false),
                    TYP_MOTIF_PROG = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    LIB_MOTIF_PROG = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ALERTE_LIT_MOTIF_PROG = table.Column<bool>(type: "bit", nullable: true),
                    DAT_MOTIF_PROG = table.Column<DateTime>(type: "date", nullable: true),
                    ECH_MOTIF_PROG = table.Column<DateTime>(type: "date", nullable: true),
                    FRAIS_MOTIF_PROG = table.Column<bool>(type: "bit", nullable: true),
                    LOGIN_USER_MOTIF_PROG = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__T_MOTIF___92C097C701D345B0", x => new { x.TYP_MOTIF_PROG, x.REF_CTR_MOTIF_PROG });
                });

            migrationBuilder.CreateTable(
                name: "T_MVT_CREDIT",
                columns: table => new
                {
                    ID_CREDIT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REF_CTR_CREDIT = table.Column<int>(type: "int", nullable: false),
                    ABRV_CREDIT = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TYP_CREDIT = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true),
                    MONT_CREDIT = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    DATE_CREDIT = table.Column<DateTime>(type: "date", nullable: true),
                    LIBELLE_LIBRE_CREDIT = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    REF_ENC_CREDIT = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    DAT_VAL_ENC_CREDIT = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_MVT_CREDIT", x => x.ID_CREDIT);
                });

            migrationBuilder.CreateTable(
                name: "T_MVT_DEBIT",
                columns: table => new
                {
                    ID_DEBIT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REF_CTR_DEBIT = table.Column<int>(type: "int", nullable: false),
                    ABEV_DEBIT = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TYP_DEBIT = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true),
                    MONT_DEBIT = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    DATE_DEBIT = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_MVT_DEBIT", x => x.ID_DEBIT);
                });

            migrationBuilder.CreateTable(
                name: "T_PROROGATION",
                columns: table => new
                {
                    ID_PROROGATION = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REF_CTR_PROG = table.Column<int>(type: "int", nullable: false),
                    TYP_PROG = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    MOTIF_PROG = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DAT_PROG = table.Column<DateTime>(type: "date", nullable: true),
                    ECH_PROG = table.Column<DateTime>(type: "date", nullable: false),
                    ETAT_PROG = table.Column<bool>(type: "bit", nullable: true),
                    ID_DET_BORD_PROG = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_PROROGATION", x => x.ID_PROROGATION);
                });

            migrationBuilder.CreateTable(
                name: "T_RELANCE",
                columns: table => new
                {
                    ID_RELANCE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REF_CTR_RELANCE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LIBELLE_RELANCE = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    DATE_RELANCE = table.Column<DateTime>(type: "date", nullable: true),
                    REF_DOC_RELANCE = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    VALIDE_RELANCE = table.Column<bool>(type: "bit", nullable: true),
                    USER_RELANCE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_RELANCE", x => x.ID_RELANCE);
                });

            migrationBuilder.CreateTable(
                name: "T_RELEVE",
                columns: table => new
                {
                    ID_RELEVE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADH_RELEVE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Contrat_RELEVE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    PP_RELEVE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Libelle_OP_RELEVE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Credit_RELEVE = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    debit_RELEVE = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    autre_RELEVE = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Date_OP_RELEVE = table.Column<DateTime>(type: "datetime", nullable: true),
                    Encours_Facture_RELEVE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Disponible_RELEVE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Date_RELEVE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_RELEVE", x => x.ID_RELEVE);
                });

            migrationBuilder.CreateTable(
                name: "T_RIB_FACTOR",
                columns: table => new
                {
                    ID_FACTOR = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RIB_FACTOR = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    VALID_RIB_FACTOR = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_RIB_FACTOR", x => new { x.ID_FACTOR, x.RIB_FACTOR });
                });

            migrationBuilder.CreateTable(
                name: "T_ROLE",
                columns: table => new
                {
                    ID_ROLE = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    LIB_ROLE = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__T_ROLE__C7D0F6576EC0713C", x => x.ID_ROLE);
                });

            migrationBuilder.CreateTable(
                name: "TABLE_UN",
                columns: table => new
                {
                    ID_TABLE_UN = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    REF_ADH_TBLE_UN = table.Column<int>(type: "int", nullable: true),
                    COMPTE_TABLE_UN = table.Column<string>(type: "nchar(15)", fixedLength: true, maxLength: 15, nullable: true),
                    CODE_TABLE_UN = table.Column<string>(type: "nchar(15)", fixedLength: true, maxLength: 15, nullable: true),
                    LIBELLEE_TABLE_UN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    INTITULE_TABLE_UN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DEBIT_TABLE_UN = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    CREDIT_TABLE_UN = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    DATE_TABLE_UN = table.Column<DateTime>(type: "date", nullable: true),
                    REF_MFG_ADH_TABLE_UN = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    COLONNE_DEUX_TABLE_UN = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    COLONNE_TROIS_TABLE_UN = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    COLONNE_QUATRE_TABLE_UN = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TJ_ACH_EX",
                columns: table => new
                {
                    ID_ACH_EX = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REF_CTR_ACH_EX = table.Column<int>(type: "int", nullable: false),
                    REF_IND_ACH_EX = table.Column<int>(type: "int", nullable: false),
                    ID_ROLE_CIR = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TJ_ADH_WEB",
                columns: table => new
                {
                    ID_WEB = table.Column<int>(type: "int", nullable: false),
                    REF_IND_WEB = table.Column<int>(type: "int", nullable: false),
                    PRE_IND_WEB = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    LOGIN_WEB = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    PWD_WEB = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    DATE_DEBUT_WEB = table.Column<DateTime>(type: "date", nullable: false),
                    DATE_FIN_WEB = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TJ_DOCUMENT_DET_BORD",
                columns: table => new
                {
                    ID_DOCUMENT_DET_BORD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_DET_BORD = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    NUM_BORD = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    REF_CTR_DET_BORD = table.Column<int>(type: "int", nullable: false),
                    REF_DOCUMENT_DET_BORD = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TJ_DOCUMENT_DET_BORD", x => x.ID_DOCUMENT_DET_BORD);
                });

            migrationBuilder.CreateTable(
                name: "TJ_LETTRAGE",
                columns: table => new
                {
                    ID_DET_BORD_LET = table.Column<int>(type: "int", nullable: false),
                    ID_ENC_LET = table.Column<int>(type: "int", nullable: false),
                    DAT_LET = table.Column<DateTime>(type: "date", nullable: false),
                    MONT_TTC_LET = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    DAT_RECONCIL = table.Column<DateTime>(type: "date", nullable: true),
                    VALIDE_LET = table.Column<bool>(type: "bit", nullable: true),
                    VALIDE_RECONCIL = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TJ_LETTR__219B3A9C0E04126B", x => new { x.ID_DET_BORD_LET, x.ID_ENC_LET, x.DAT_LET });
                });

            migrationBuilder.CreateTable(
                name: "TR_ACTPROF_BCT",
                columns: table => new
                {
                    CodeSousClasse = table.Column<string>(name: "Code SousClasse", type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CodeSection = table.Column<string>(name: "Code Section", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Section = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CodeSousSection = table.Column<string>(name: "Code SousSection", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SousSection = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CodeActivité = table.Column<string>(name: "Code Activité", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CodeClasse = table.Column<string>(name: "Code Classe", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Classe = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CodeClasse1 = table.Column<string>(name: "Code Classe1", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SousClasse = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TR_ACTPROF_BCT", x => x.CodeSousClasse);
                });

            migrationBuilder.CreateTable(
                name: "TR_Ag_Bq",
                columns: table => new
                {
                    Code_Bq_Ag = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code_Bq = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Banque = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Code_Ag = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Agence = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TR_Ag_Bq", x => x.Code_Bq_Ag);
                });

            migrationBuilder.CreateTable(
                name: "TR_COMM_FACTORING",
                columns: table => new
                {
                    ID_COMM_FACT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TYP_COMM_FACTORING = table.Column<string>(type: "char(15)", unicode: false, fixedLength: true, maxLength: 15, nullable: false),
                    TX_COMM_FACTORING = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    MONT_MIN_DOC_COMM_FACTORING = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    MONT_MIN_CTR_COMM_FACTORING = table.Column<decimal>(type: "decimal(15,3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TR_COMM_FACTORING", x => x.ID_COMM_FACT);
                });

            migrationBuilder.CreateTable(
                name: "TR_CP",
                columns: table => new
                {
                    ID_CP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CP = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    Ville = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: true),
                    Code_Gouvernorat = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Gouvernorat = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: true),
                    Code_Region = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Region = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TR_CP", x => x.ID_CP);
                });

            migrationBuilder.CreateTable(
                name: "TR_INT_FINANCEMENT",
                columns: table => new
                {
                    ID_TR_INT_FIN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TYP_INSTR_INT_FIN = table.Column<string>(type: "char(15)", unicode: false, fixedLength: true, maxLength: 15, nullable: false),
                    TX_INT_MARCHE_INT_FIN = table.Column<decimal>(type: "decimal(5,3)", nullable: true),
                    TX_MARGE_CTR_INT_FIN = table.Column<decimal>(type: "decimal(5,3)", nullable: true),
                    DELAI_MAX_PAI_INT_FIN = table.Column<short>(type: "smallint", nullable: true),
                    PRECOMPTE_INT_FIN = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    MAJOR_INT_INT_FIN = table.Column<decimal>(type: "decimal(5,3)", nullable: true),
                    DAT_DEB_VALID_INT_FIN = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TR_INT_FINANCEMENT", x => x.ID_TR_INT_FIN);
                });

            migrationBuilder.CreateTable(
                name: "TR_LIST_VAL",
                columns: table => new
                {
                    ID_LIST_VAL = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ABR_LIST_VAL = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    TYP_LIST_VAL = table.Column<string>(type: "char(20)", unicode: false, fixedLength: true, maxLength: 20, nullable: false),
                    ORD_LIST_VAL = table.Column<short>(type: "smallint", nullable: true),
                    LIB_LIST_VAL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    COM_LIST_VAL = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    NB_JOUR_LIST_VAL = table.Column<int>(type: "int", nullable: true),
                    TYPE_RECOUVREMENT = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TR_LIST___5D96956109A971A2", x => x.ID_LIST_VAL);
                });

            migrationBuilder.CreateTable(
                name: "TR_LISTE_FRAIS_DIVERS",
                columns: table => new
                {
                    ID_ListeFraisDivers = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ABREV_FRAIS_DIVERS = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    LIB_FRAIS_DIVERS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    MONT_FRAIS_DIVERS = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    TYPE_FRAIS_DIVERS = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TR_LISTE_FRAIS_DIVERS", x => x.ID_ListeFraisDivers);
                });

            migrationBuilder.CreateTable(
                name: "TR_NLDP",
                columns: table => new
                {
                    ID_NLDP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LIB_NT = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ABRV_NAT = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    LIB_LANG = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ABRV_LANG = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    LIB_DEVISE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ABRV_DEVISE = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    LIB_PAYS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ABRV_PAYS = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TR_NLDP__A9D6B5AE32767D0B", x => x.ID_NLDP);
                });

            migrationBuilder.CreateTable(
                name: "TR_PARAM_PIECE",
                columns: table => new
                {
                    TYP_PARAM_PIECE = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    LIB_PARAM_PIECE = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    SIGN_PARAM_PIECE = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TR_PARAM__596D594EB71BFBC6", x => x.TYP_PARAM_PIECE);
                });

            migrationBuilder.CreateTable(
                name: "TR_RIB",
                columns: table => new
                {
                    RIB_RIB = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    REF_IND_RIB = table.Column<int>(type: "int", nullable: false),
                    ACTIF_RIB = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TR_RIB__2CA2FF07803A45B1", x => x.RIB_RIB);
                });

            migrationBuilder.CreateTable(
                name: "TR_TMM",
                columns: table => new
                {
                    ID_TMM = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DATE_DEBUT_TMM = table.Column<DateTime>(type: "date", nullable: true),
                    DATE_FIN_TMM = table.Column<DateTime>(type: "date", nullable: true),
                    TAUX_TMM = table.Column<decimal>(type: "decimal(6,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TR_TMM", x => x.ID_TMM);
                });

            migrationBuilder.CreateTable(
                name: "TR_TVA",
                columns: table => new
                {
                    ID_TVA = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LIB_TVA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    VAL_TVA = table.Column<decimal>(type: "decimal(4,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TR_TVA__27BFF8EE0D7A0286", x => x.ID_TVA);
                });

            migrationBuilder.CreateTable(
                name: "TS_GRP_USER",
                columns: table => new
                {
                    ID_GRP_USER = table.Column<int>(type: "int", nullable: false),
                    LIB_GRP_USER = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ACTIF_GRP_USER = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TS_GRP_U__D6346B9A4DDCEA49", x => x.ID_GRP_USER);
                });

            migrationBuilder.CreateTable(
                name: "TS_USERS_WEB",
                columns: table => new
                {
                    ID_USER_WEB = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REF_IND_WEB = table.Column<int>(type: "int", nullable: false),
                    LOGIN_WEB = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PASSWORD_WEB = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    LOGO_WEB = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ACTIF_USER_WEB = table.Column<bool>(type: "bit", nullable: false),
                    DATE_FIN_COMPTE = table.Column<DateTime>(type: "date", nullable: true),
                    ONE_SIGNAL_PLAYER_ID = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TS_USERS_WEB", x => x.ID_USER_WEB);
                });

            migrationBuilder.CreateTable(
                name: "T_CALC_INT",
                columns: table => new
                {
                    ID_CALC_INT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REF_CTR_CALC_INT = table.Column<int>(type: "int", nullable: false),
                    MONT_CALC_INT = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    DAT_CALC_INT = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_CALC_INT", x => x.ID_CALC_INT);
                    table.ForeignKey(
                        name: "FK_T_CALC_INT_T_CONTRAT",
                        column: x => x.REF_CTR_CALC_INT,
                        principalTable: "T_CONTRAT",
                        principalColumn: "REF_CTR");
                });

            migrationBuilder.CreateTable(
                name: "T_DET_BORD",
                columns: table => new
                {
                    ID_DET_BORD = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    REF_CTR_DET_BORD = table.Column<int>(type: "int", nullable: false),
                    ANNEE_BORD = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    NUM_BORD = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    TYP_DET_BORD = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    NUM_CREANCE_ASS_BORD = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TYP_ASS_DET_BORD = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true),
                    DAT_DET_BORD = table.Column<DateTime>(type: "date", nullable: true),
                    MONT_TTC_DET_BORD = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    DEVISE_DET_BORD = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: true),
                    ECH_DET_BORD = table.Column<short>(type: "smallint", nullable: true),
                    ECH_APR_PROROG_DET_BORD = table.Column<DateTime>(type: "date", nullable: true),
                    MONT_OUV_DET_BORD = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    DELAI_PAIE_DET_BORD = table.Column<short>(type: "smallint", nullable: true),
                    MODE_REG_DET_BORD = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true),
                    TYP_REG_DET_BORD = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true),
                    TX_FDG_DET_BORD = table.Column<decimal>(type: "decimal(5,3)", nullable: true),
                    TX_COMM_FACT_DET_BORD = table.Column<decimal>(type: "decimal(6,4)", nullable: true),
                    ANNUL_DET_BORD = table.Column<bool>(type: "bit", nullable: true),
                    VALIDE_DET_BORD = table.Column<bool>(type: "bit", nullable: true),
                    REF_IND_DET_BORD = table.Column<int>(type: "int", nullable: true),
                    MONT_FDG_DET_BORD = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    MONT_FDG_LIBERE_DET_BORD = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    MONT_COMM_FACT_DET_BORD = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    TX_TVA_COMM_FACT_DET_BORD = table.Column<decimal>(type: "decimal(5,3)", nullable: true),
                    MONT_TVA_COMM_FACT_DET_BORD = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    MONT_TTC_COMM_FACT_DET_BORD = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    ID_CALC_DISPO_DET_BORD = table.Column<int>(type: "int", nullable: true),
                    REF_DET_BORD = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    COMM_DET_BORD = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RETENU_DET_BORD = table.Column<decimal>(type: "decimal(15,3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__T_DET_BO__B2C9266D6319B466", x => new { x.ID_DET_BORD, x.REF_CTR_DET_BORD });
                    table.ForeignKey(
                        name: "FK__T_DET_BOR__REF_C__6501FCD8",
                        column: x => x.REF_CTR_DET_BORD,
                        principalTable: "T_CONTRAT",
                        principalColumn: "REF_CTR");
                });

            migrationBuilder.CreateTable(
                name: "T_ADRESSE",
                columns: table => new
                {
                    ID_ADR = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REF_IND_ADR = table.Column<int>(type: "int", nullable: false),
                    LIB_ADR = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    CP_ADR = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ID_LOC_ADR = table.Column<short>(type: "smallint", nullable: true),
                    ID_DELEG_ADR = table.Column<short>(type: "smallint", nullable: true),
                    ID_GOUV_ADR = table.Column<short>(type: "smallint", nullable: true),
                    ID_NLDP = table.Column<short>(type: "smallint", nullable: true),
                    ACTIF_ADR = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__T_ADRESS__2A7CD608047AA831", x => x.ID_ADR);
                    table.ForeignKey(
                        name: "FK__T_ADRESSE__REF_I__0662F0A3",
                        column: x => x.REF_IND_ADR,
                        principalTable: "T_INDIVIDU",
                        principalColumn: "REF_IND");
                });

            migrationBuilder.CreateTable(
                name: "TJ_CIR",
                columns: table => new
                {
                    ID_CIR = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REF_CTR_CIR = table.Column<int>(type: "int", nullable: false),
                    REF_IND_CIR = table.Column<int>(type: "int", nullable: false),
                    ID_ROLE_CIR = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIR", x => x.ID_CIR);
                    table.ForeignKey(
                        name: "FK_CIR_CONTRAT",
                        column: x => x.REF_CTR_CIR,
                        principalTable: "T_CONTRAT",
                        principalColumn: "REF_CTR");
                    table.ForeignKey(
                        name: "FK_CIR_INDIVIDU",
                        column: x => x.REF_IND_CIR,
                        principalTable: "T_INDIVIDU",
                        principalColumn: "REF_IND");
                    table.ForeignKey(
                        name: "FK_CIR_ROLE",
                        column: x => x.ID_ROLE_CIR,
                        principalTable: "T_ROLE",
                        principalColumn: "ID_ROLE");
                });

            migrationBuilder.CreateTable(
                name: "TJ_GRP_PERMISSIONS",
                columns: table => new
                {
                    ID_GRP = table.Column<int>(type: "int", nullable: false),
                    ID_PERMISSION = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TJ_GRP_PERMISSIONS", x => new { x.ID_GRP, x.ID_PERMISSION });
                    table.ForeignKey(
                        name: "FK_TJ_GRP_PERMISSIONS_TR_LIST_VAL",
                        column: x => x.ID_PERMISSION,
                        principalTable: "TR_LIST_VAL",
                        principalColumn: "ID_LIST_VAL");
                });

            migrationBuilder.CreateTable(
                name: "TS_USER",
                columns: table => new
                {
                    ID_USER = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_GRP_USER = table.Column<int>(type: "int", nullable: false),
                    NOM_USER = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PRE_USER = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LOGIN_USER = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    MDP_USER = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ACTIF_USER = table.Column<bool>(type: "bit", nullable: false),
                    FONCTION_USER = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SERVICE_USER = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DIRECTION_USER = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AGENCE_USER = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MAIL_USER = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TEL_FIXE_USER = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MOBILE_USER = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PHOTO_USER = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ONE_SIGNAL_PLAYER_ID = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TS_USER__95F4844059904A2C", x => x.ID_USER);
                    table.ForeignKey(
                        name: "FK__TS_USER__ID_GRP___5C6CB6D7",
                        column: x => x.ID_GRP_USER,
                        principalTable: "TS_GRP_USER",
                        principalColumn: "ID_GRP_USER");
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_ADRESSE_REF_IND_ADR",
                table: "T_ADRESSE",
                column: "REF_IND_ADR");

            migrationBuilder.CreateIndex(
                name: "IX_T_CALC_INT_REF_CTR_CALC_INT",
                table: "T_CALC_INT",
                column: "REF_CTR_CALC_INT");

            migrationBuilder.CreateIndex(
                name: "IX_T_DET_BORD_REF_CTR_DET_BORD",
                table: "T_DET_BORD",
                column: "REF_CTR_DET_BORD");

            migrationBuilder.CreateIndex(
                name: "UQ_NOM_PRENOM",
                table: "T_INDIVIDU",
                columns: new[] { "NOM_IND", "PRE_IND" },
                unique: true,
                filter: "[NOM_IND] IS NOT NULL AND [PRE_IND] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TJ_CIR_ID_ROLE_CIR",
                table: "TJ_CIR",
                column: "ID_ROLE_CIR");

            migrationBuilder.CreateIndex(
                name: "IX_TJ_CIR_REF_IND_CIR",
                table: "TJ_CIR",
                column: "REF_IND_CIR");

            migrationBuilder.CreateIndex(
                name: "UQ_CIR_CONTRAT_INDIVIDU_ROLE",
                table: "TJ_CIR",
                columns: new[] { "REF_CTR_CIR", "REF_IND_CIR", "ID_ROLE_CIR" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TJ_GRP_PERMISSIONS_ID_PERMISSION",
                table: "TJ_GRP_PERMISSIONS",
                column: "ID_PERMISSION");

            migrationBuilder.CreateIndex(
                name: "UQ_NLDP",
                table: "TR_NLDP",
                columns: new[] { "LIB_NT", "ABRV_NAT", "LIB_LANG", "ABRV_LANG", "LIB_DEVISE", "ABRV_DEVISE", "LIB_PAYS", "ABRV_PAYS" },
                unique: true,
                filter: "[LIB_NT] IS NOT NULL AND [ABRV_NAT] IS NOT NULL AND [LIB_LANG] IS NOT NULL AND [ABRV_LANG] IS NOT NULL AND [LIB_DEVISE] IS NOT NULL AND [ABRV_DEVISE] IS NOT NULL AND [LIB_PAYS] IS NOT NULL AND [ABRV_PAYS] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TS_USER_ID_GRP_USER",
                table: "TS_USER",
                column: "ID_GRP_USER");

            migrationBuilder.CreateIndex(
                name: "UQ_USER",
                table: "TS_USER",
                column: "LOGIN_USER",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Users_UserId",
                table: "Order",
                column: "UserId",
                principalSchema: "usr",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TContact_TIndividu_individuId",
                table: "TContact",
                column: "individuId",
                principalTable: "TIndividu",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TRib_TIndividu_individuId",
                table: "TRib",
                column: "individuId",
                principalTable: "TIndividu",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Users_UserId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_TContact_TIndividu_individuId",
                table: "TContact");

            migrationBuilder.DropForeignKey(
                name: "FK_TRib_TIndividu_individuId",
                table: "TRib");

            migrationBuilder.DropTable(
                name: "T_ADRESSE");

            migrationBuilder.DropTable(
                name: "T_AUTRE_F_RELELE");

            migrationBuilder.DropTable(
                name: "T_BCT_RCM00");

            migrationBuilder.DropTable(
                name: "T_BORD_FACTOR");

            migrationBuilder.DropTable(
                name: "T_BORD_MFG");

            migrationBuilder.DropTable(
                name: "T_BORDEREAU");

            migrationBuilder.DropTable(
                name: "T_Bordereau_MFG");

            migrationBuilder.DropTable(
                name: "T_CALC_DISPO");

            migrationBuilder.DropTable(
                name: "T_CALC_INT");

            migrationBuilder.DropTable(
                name: "T_CALC_INT_IR");

            migrationBuilder.DropTable(
                name: "T_COMM_FACTORING");

            migrationBuilder.DropTable(
                name: "T_Comm_MFG");

            migrationBuilder.DropTable(
                name: "T_COMM_RELEVE");

            migrationBuilder.DropTable(
                name: "T_COMMENT");

            migrationBuilder.DropTable(
                name: "T_COMPTE");

            migrationBuilder.DropTable(
                name: "T_CONFIGURATION_EMAIL");

            migrationBuilder.DropTable(
                name: "T_CONTACT");

            migrationBuilder.DropTable(
                name: "T_CONTACT_FACTOR");

            migrationBuilder.DropTable(
                name: "T_DEM_FIN_CREDIT");

            migrationBuilder.DropTable(
                name: "T_DEM_LIMITE");

            migrationBuilder.DropTable(
                name: "T_Det_Achat_RELEVE");

            migrationBuilder.DropTable(
                name: "T_DET_ASS");

            migrationBuilder.DropTable(
                name: "T_DET_BORD");

            migrationBuilder.DropTable(
                name: "T_DOC_GED");

            migrationBuilder.DropTable(
                name: "T_DOC_PHYSIQUE");

            migrationBuilder.DropTable(
                name: "T_EC_COMPTABLE");

            migrationBuilder.DropTable(
                name: "T_EC_CPT");

            migrationBuilder.DropTable(
                name: "T_EMAIL");

            migrationBuilder.DropTable(
                name: "T_ENCAISSEMENT");

            migrationBuilder.DropTable(
                name: "T_ETAT_DISPO");

            migrationBuilder.DropTable(
                name: "T_EXTRAIT");

            migrationBuilder.DropTable(
                name: "T_FACTOR");

            migrationBuilder.DropTable(
                name: "T_Fichiers_Scan");

            migrationBuilder.DropTable(
                name: "T_FINANCEMENT");

            migrationBuilder.DropTable(
                name: "T_FOND_GARANTIE");

            migrationBuilder.DropTable(
                name: "T_FRAIS_DIVERS");

            migrationBuilder.DropTable(
                name: "T_FRAIS_PAIEMENT");

            migrationBuilder.DropTable(
                name: "T_FRAIS_RELEVE");

            migrationBuilder.DropTable(
                name: "T_GROUPE");

            migrationBuilder.DropTable(
                name: "T_HISTORIQUE");

            migrationBuilder.DropTable(
                name: "T_IMPAYE");

            migrationBuilder.DropTable(
                name: "T_INFO_CTR");

            migrationBuilder.DropTable(
                name: "T_INT_FINANCEMENT");

            migrationBuilder.DropTable(
                name: "T_LITIGE");

            migrationBuilder.DropTable(
                name: "T_MOTIF_LIT");

            migrationBuilder.DropTable(
                name: "T_MOTIF_PROG");

            migrationBuilder.DropTable(
                name: "T_MVT_CREDIT");

            migrationBuilder.DropTable(
                name: "T_MVT_DEBIT");

            migrationBuilder.DropTable(
                name: "T_PROROGATION");

            migrationBuilder.DropTable(
                name: "T_RELANCE");

            migrationBuilder.DropTable(
                name: "T_RELEVE");

            migrationBuilder.DropTable(
                name: "T_RIB_FACTOR");

            migrationBuilder.DropTable(
                name: "TABLE_UN");

            migrationBuilder.DropTable(
                name: "TJ_ACH_EX");

            migrationBuilder.DropTable(
                name: "TJ_ADH_WEB");

            migrationBuilder.DropTable(
                name: "TJ_CIR");

            migrationBuilder.DropTable(
                name: "TJ_DOCUMENT_DET_BORD");

            migrationBuilder.DropTable(
                name: "TJ_GRP_PERMISSIONS");

            migrationBuilder.DropTable(
                name: "TJ_LETTRAGE");

            migrationBuilder.DropTable(
                name: "TR_ACTPROF_BCT");

            migrationBuilder.DropTable(
                name: "TR_Ag_Bq");

            migrationBuilder.DropTable(
                name: "TR_COMM_FACTORING");

            migrationBuilder.DropTable(
                name: "TR_CP");

            migrationBuilder.DropTable(
                name: "TR_INT_FINANCEMENT");

            migrationBuilder.DropTable(
                name: "TR_LISTE_FRAIS_DIVERS");

            migrationBuilder.DropTable(
                name: "TR_NLDP");

            migrationBuilder.DropTable(
                name: "TR_PARAM_PIECE");

            migrationBuilder.DropTable(
                name: "TR_RIB");

            migrationBuilder.DropTable(
                name: "TR_TMM");

            migrationBuilder.DropTable(
                name: "TR_TVA");

            migrationBuilder.DropTable(
                name: "TS_USER");

            migrationBuilder.DropTable(
                name: "TS_USERS_WEB");

            migrationBuilder.DropTable(
                name: "T_CONTRAT");

            migrationBuilder.DropTable(
                name: "T_INDIVIDU");

            migrationBuilder.DropTable(
                name: "T_ROLE");

            migrationBuilder.DropTable(
                name: "TR_LIST_VAL");

            migrationBuilder.DropTable(
                name: "TS_GRP_USER");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TRib",
                table: "TRib");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TIndividu",
                table: "TIndividu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TContact",
                table: "TContact");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.RenameTable(
                name: "TRib",
                newName: "TRibs");

            migrationBuilder.RenameTable(
                name: "TIndividu",
                newName: "TIndividus");

            migrationBuilder.RenameTable(
                name: "TContact",
                newName: "TContacts");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameIndex(
                name: "IX_TRib_individuId",
                table: "TRibs",
                newName: "IX_TRibs_individuId");

            migrationBuilder.RenameIndex(
                name: "IX_TContact_individuId",
                table: "TContacts",
                newName: "IX_TContacts_individuId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_UserId",
                table: "Orders",
                newName: "IX_Orders_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TRibs",
                table: "TRibs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TIndividus",
                table: "TIndividus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TContacts",
                table: "TContacts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders",
                column: "UserId",
                principalSchema: "usr",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TContacts_TIndividus_individuId",
                table: "TContacts",
                column: "individuId",
                principalTable: "TIndividus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TRibs_TIndividus_individuId",
                table: "TRibs",
                column: "individuId",
                principalTable: "TIndividus",
                principalColumn: "Id");
        }
    }
}
