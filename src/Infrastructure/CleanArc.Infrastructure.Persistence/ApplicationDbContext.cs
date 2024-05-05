using System.Reflection;
using CleanArc.Domain;
using CleanArc.Domain.Common;
using CleanArc.Domain.Entities;
using CleanArc.Domain.Entities.DTO;
using CleanArc.Domain.Entities.User;
using CleanArc.Domain.StoredProcuderModel;
using CleanArc.SharedKernel.Extensions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using T_ENCAISSEMENT = CleanArc.Domain.Entities.T_ENCAISSEMENT;

namespace CleanArc.Infrastructure.Persistence;

public class ApplicationDbContext: IdentityDbContext<User, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
{
    public virtual DbSet<TABLE_UN> TABLE_UNs { get; set; }

    public virtual DbSet<TJ_ACH_EX> TJ_ACH_EXes { get; set; }

    public virtual DbSet<TJ_ADH_WEB> TJ_ADH_WEBs { get; set; }

    public virtual DbSet<TJ_CIR> TJ_CIRs { get; set; }

    public virtual DbSet<TJ_DOCUMENT_DET_BORD> TJ_DOCUMENT_DET_BORDs { get; set; }

    public virtual DbSet<TJ_GRP_PERMISSION> TJ_GRP_PERMISSIONs { get; set; }

    public virtual DbSet<TJ_LETTRAGE> TJ_LETTRAGEs { get; set; }

    public virtual DbSet<TR_ACTPROF_BCT> TR_ACTPROF_BCTs { get; set; }

    public virtual DbSet<TR_Ag_Bq> TR_Ag_Bqs { get; set; }

    public virtual DbSet<TR_COMM_FACTORING> TR_COMM_FACTORINGs { get; set; }

    public virtual DbSet<TR_CP> TR_CPs { get; set; }

    public virtual DbSet<TR_INT_FINANCEMENT> TR_INT_FINANCEMENTs { get; set; }

    public virtual DbSet<TR_LISTE_FRAIS_DIVER> TR_LISTE_FRAIS_DIVERs { get; set; }

    public virtual DbSet<TR_LIST_VAL> TR_LIST_VALs { get; set; }

    public virtual DbSet<TR_NLDP> TR_NLDPs { get; set; }

    public virtual DbSet<TR_PARAM_PIECE> TR_PARAM_PIECEs { get; set; }

    public virtual DbSet<TR_RIB> TR_RIBs { get; set; }

    public virtual DbSet<TR_TMM> TR_TMMs { get; set; }

    public virtual DbSet<TR_TVA> TR_TVAs { get; set; }

    public virtual DbSet<TS_GRP_USER> TS_GRP_USERs { get; set; }

    public virtual DbSet<TS_USER> TS_USERs { get; set; }

    public virtual DbSet<TS_USERS_WEB> TS_USERS_WEBs { get; set; }

    public virtual DbSet<T_ADRESSE> T_ADRESSEs { get; set; }

    public virtual DbSet<T_AUTRE_F_RELELE> T_AUTRE_F_RELELEs { get; set; }

    public virtual DbSet<T_BCT_RCM00> T_BCT_RCM00s { get; set; }

    public virtual DbSet<T_BORDEREAU> T_BORDEREAUs { get; set; }

    public virtual DbSet<T_BORD_FACTOR> T_BORD_FACTORs { get; set; }

    public virtual DbSet<T_BORD_MFG> T_BORD_MFGs { get; set; }

    public virtual DbSet<T_Bordereau_MFG> T_Bordereau_MFGs { get; set; }

    public virtual DbSet<T_CALC_DISPO> T_CALC_DISPOs { get; set; }

    public virtual DbSet<T_CALC_INT> T_CALC_INTs { get; set; }

    public virtual DbSet<T_CALC_INT_IR> T_CALC_INT_IRs { get; set; }

    public virtual DbSet<T_COMMENT> T_COMMENTs { get; set; }

    public virtual DbSet<T_COMM_FACTORING> T_COMM_FACTORINGs { get; set; }

    public virtual DbSet<T_COMM_RELEVE> T_COMM_RELEVEs { get; set; }

    public virtual DbSet<T_COMPTE> T_COMPTEs { get; set; }

    public virtual DbSet<T_CONFIGURATION_EMAIL> T_CONFIGURATION_EMAILs { get; set; }

    public virtual DbSet<T_CONTACT> T_CONTACTs { get; set; }

    public virtual DbSet<T_CONTACT_FACTOR> T_CONTACT_FACTORs { get; set; }

    public virtual DbSet<T_CONTRAT> T_CONTRATs { get; set; }

    public virtual DbSet<T_Comm_MFG> T_Comm_MFGs { get; set; }

    public virtual DbSet<T_DEM_FIN_CREDIT> T_DEM_FIN_CREDITs { get; set; }

    public virtual DbSet<T_DEM_LIMITE> T_DEM_LIMITEs { get; set; }

    public virtual DbSet<T_DET_ASS> T_DET_ASSes { get; set; }

    public virtual DbSet<T_DET_BORD> T_DET_BORDs { get; set; }

    public virtual DbSet<T_DOC_GED> T_DOC_GEDs { get; set; }

    public virtual DbSet<T_DOC_PHYSIQUE> T_DOC_PHYSIQUEs { get; set; }

    public virtual DbSet<T_Det_Achat_RELEVE> T_Det_Achat_RELEVEs { get; set; }

    public virtual DbSet<T_EC_COMPTABLE> T_EC_COMPTABLEs { get; set; }

    public virtual DbSet<T_EC_CPT> T_EC_CPTs { get; set; }

    public virtual DbSet<T_EMAIL> T_EMAILs { get; set; }

    public virtual DbSet<T_ENCAISSEMENT> T_ENCAISSEMENTs { get; set; }

    public virtual DbSet<T_ETAT_DISPO> T_ETAT_DISPOs { get; set; }

    public virtual DbSet<T_EXTRAIT> T_EXTRAITs { get; set; }

    public virtual DbSet<T_FACTOR> T_FACTORs { get; set; }

    public virtual DbSet<T_FINANCEMENT> T_FINANCEMENTs { get; set; }

    public virtual DbSet<T_FOND_GARANTIE> T_FOND_GARANTIEs { get; set; }

    public virtual DbSet<T_FRAIS_DIVER> T_FRAIS_DIVERs { get; set; }

    public virtual DbSet<T_FRAIS_PAIEMENT> T_FRAIS_PAIEMENTs { get; set; }

    public virtual DbSet<T_FRAIS_RELEVE> T_FRAIS_RELEVEs { get; set; }

    public virtual DbSet<T_Fichiers_Scan> T_Fichiers_Scans { get; set; }

    public virtual DbSet<T_GROUPE> T_GROUPEs { get; set; }

    public virtual DbSet<T_HISTORIQUE> T_HISTORIQUEs { get; set; }

    public virtual DbSet<T_IMPAYE> T_IMPAYEs { get; set; }

    public virtual DbSet<T_INDIVIDU> T_INDIVIDUs { get; set; }

    public virtual DbSet<T_INFO_CTR> T_INFO_CTRs { get; set; }

    public virtual DbSet<T_INT_FINANCEMENT> T_INT_FINANCEMENTs { get; set; }

    public virtual DbSet<T_LITIGE> T_LITIGEs { get; set; }

    public virtual DbSet<T_MOTIF_LIT> T_MOTIF_LITs { get; set; }

    public virtual DbSet<T_MOTIF_PROG> T_MOTIF_PROGs { get; set; }

    public virtual DbSet<T_MVT_CREDIT> T_MVT_CREDITs { get; set; }

    public virtual DbSet<T_MVT_DEBIT> T_MVT_DEBITs { get; set; }

    public virtual DbSet<T_PROROGATION> T_PROROGATIONs { get; set; }

    public virtual DbSet<T_RELANCE> T_RELANCEs { get; set; }

    public virtual DbSet<T_RELEVE> T_RELEVEs { get; set; }

    public virtual DbSet<T_RIB_FACTOR> T_RIB_FACTORs { get; set; }

    public virtual DbSet<T_ROLE> T_ROLEs { get; set; }
    public DbSet<SumOfMnt> SumOfMnts { get; set; }
    public DbSet<usp_FRAIS_DIVERS> usp_FRAIS_DIVERS { get; set; }
    public DbSet<usp_FRAIS_PAIEMENT_V> usp_FRAIS_PAIEMENT_V { get; set; }
    public DbSet<usp_FRAIS_PAIEMENT_T> usp_FRAIS_PAIEMENT_T { get; set; }
    public DbSet<usp_FRAIS_PAIEMENT_C> usp_FRAIS_PAIEMENT_C { get; set; }

    public  DbSet<All_Ecran_Financements> All_Ecran_Financements { get; set; }
    
    public  DbSet<UspEtatDepassLimACHResult> usp_Etat_Depass_Lim_ACH{ get; set; }
    public DbSet<T_IMPAYE_DTO> ListeDesImpayes { get; set; }
    public DbSet<T_RECOUVREMENT_DTO> Recouvrement_All_Factures { get; set; } 
    public DbSet<T_RECOUVREMENT_DTO>FacturesEchu { get; set; }
    
    public DbSet<T_RECOUVREMENT_DTO>FacturesNonEchu { get; set; }
    


    public ApplicationDbContext(DbContextOptions options)
        : base(options)
    {
        base.SavingChanges += OnSavingChanges;
    }

    private void OnSavingChanges(object sender, SavingChangesEventArgs e)
    {
        _cleanString();
        ConfigureEntityDates();
    }

    private void _cleanString()
    {
        var changedEntities = ChangeTracker.Entries()
            .Where(x => x.State == EntityState.Added || x.State == EntityState.Modified);
        foreach (var item in changedEntities)
        {
            if (item.Entity == null)
                continue;

            var properties = item.Entity.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => p.CanRead && p.CanWrite && p.PropertyType == typeof(string));

            foreach (var property in properties)
            {
                var propName = property.Name;
                var val = (string)property.GetValue(item.Entity, null);

                if (val.HasValue())
                {
                    var newVal = val.Fa2En().FixPersianChars();
                    if (newVal == val)
                        continue;
                    property.SetValue(item.Entity, newVal, null);
                }
            }
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TABLE_UN>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TABLE_UN");

            entity.Property(e => e.CODE_TABLE_UN)
                .HasMaxLength(15)
                .IsFixedLength();
            entity.Property(e => e.COLONNE_DEUX_TABLE_UN)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.COLONNE_QUATRE_TABLE_UN)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.COLONNE_TROIS_TABLE_UN)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.COMPTE_TABLE_UN)
                .HasMaxLength(15)
                .IsFixedLength();
            entity.Property(e => e.CREDIT_TABLE_UN).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.DATE_TABLE_UN).HasColumnType("date");
            entity.Property(e => e.DEBIT_TABLE_UN).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.ID_TABLE_UN)
                .IsRequired()
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.INTITULE_TABLE_UN)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LIBELLEE_TABLE_UN)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.REF_MFG_ADH_TABLE_UN)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TJ_ACH_EX>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TJ_ACH_EX");

            entity.Property(e => e.ID_ACH_EX).ValueGeneratedOnAdd();
            entity.Property(e => e.ID_ROLE_CIR)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TJ_ADH_WEB>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TJ_ADH_WEB");

            entity.Property(e => e.DATE_DEBUT_WEB).HasColumnType("date");
            entity.Property(e => e.DATE_FIN_WEB).HasColumnType("date");
            entity.Property(e => e.LOGIN_WEB)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PRE_IND_WEB)
                .IsRequired()
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.PWD_WEB)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TJ_CIR>(entity =>
        {
            entity.HasKey(e => e.ID_CIR).HasName("PK_CIR");

            entity.ToTable("TJ_CIR");

            entity.HasIndex(e => new { e.REF_CTR_CIR, e.REF_IND_CIR, e.ID_ROLE_CIR }, "UQ_CIR_CONTRAT_INDIVIDU_ROLE").IsUnique();

            entity.Property(e => e.ID_ROLE_CIR)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.ID_ROLE_CIRNavigation).WithMany(p => p.TJ_CIRs)
                .HasForeignKey(d => d.ID_ROLE_CIR)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CIR_ROLE");

            entity.HasOne(d => d.REF_CTR_CIRNavigation).WithMany(p => p.TJ_CIRs)
                .HasForeignKey(d => d.REF_CTR_CIR)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CIR_CONTRAT");

            entity.HasOne(d => d.REF_IND_CIRNavigation).WithMany(p => p.TJ_CIRs)
                .HasForeignKey(d => d.REF_IND_CIR)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CIR_INDIVIDU");
        });

        modelBuilder.Entity<TJ_DOCUMENT_DET_BORD>(entity =>
        {
            entity.HasKey(e => e.ID_DOCUMENT_DET_BORD);

            entity.ToTable("TJ_DOCUMENT_DET_BORD");

            entity.Property(e => e.ID_DET_BORD)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.NUM_BORD)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.REF_DOCUMENT_DET_BORD)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TJ_GRP_PERMISSION>(entity =>
        {
            entity.HasKey(e => new { e.ID_GRP, e.ID_PERMISSION });

            entity.ToTable("TJ_GRP_PERMISSIONS");

            entity.HasOne(d => d.ID_PERMISSIONNavigation).WithMany(p => p.TJ_GRP_PERMISSIONs)
                .HasForeignKey(d => d.ID_PERMISSION)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TJ_GRP_PERMISSIONS_TR_LIST_VAL");
        });

        modelBuilder.Entity<TJ_LETTRAGE>(entity =>
        {
            entity.HasKey(e => new { e.ID_DET_BORD_LET, e.ID_ENC_LET, e.DAT_LET }).HasName("PK__TJ_LETTR__219B3A9C0E04126B");

            entity.ToTable("TJ_LETTRAGE");

            entity.Property(e => e.DAT_LET).HasColumnType("date");
            entity.Property(e => e.DAT_RECONCIL).HasColumnType("date");
            entity.Property(e => e.MONT_TTC_LET).HasColumnType("decimal(15, 3)");
        });

        modelBuilder.Entity<TR_ACTPROF_BCT>(entity =>
        {
            entity.HasKey(e => e.Code_SousClasse);

            entity.ToTable("TR_ACTPROF_BCT");

            entity.Property(e => e.Code_SousClasse)
                .HasMaxLength(255)
                .HasColumnName("Code SousClasse");
            entity.Property(e => e.Classe).HasMaxLength(255);
            entity.Property(e => e.Code_Activité)
                .HasMaxLength(255)
                .HasColumnName("Code Activité");
            entity.Property(e => e.Code_Classe)
                .HasMaxLength(255)
                .HasColumnName("Code Classe");
            entity.Property(e => e.Code_Classe1)
                .HasMaxLength(255)
                .HasColumnName("Code Classe1");
            entity.Property(e => e.Code_Section)
                .HasMaxLength(255)
                .HasColumnName("Code Section");
            entity.Property(e => e.Code_SousSection)
                .HasMaxLength(255)
                .HasColumnName("Code SousSection");
            entity.Property(e => e.Section).HasMaxLength(255);
            entity.Property(e => e.SousClasse).HasMaxLength(255);
            entity.Property(e => e.SousSection).HasMaxLength(255);
        });

        modelBuilder.Entity<TR_Ag_Bq>(entity =>
        {
            entity.HasKey(e => e.Code_Bq_Ag);

            entity.ToTable("TR_Ag_Bq");

            entity.Property(e => e.Code_Bq_Ag).HasMaxLength(255);
            entity.Property(e => e.Agence).HasMaxLength(255);
            entity.Property(e => e.Banque).HasMaxLength(255);
            entity.Property(e => e.Code_Ag).HasMaxLength(255);
            entity.Property(e => e.Code_Bq).HasMaxLength(255);
        });

        modelBuilder.Entity<TR_COMM_FACTORING>(entity =>
        {
            entity.HasKey(e => e.ID_COMM_FACT);

            entity.ToTable("TR_COMM_FACTORING");

            entity.Property(e => e.MONT_MIN_CTR_COMM_FACTORING).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.MONT_MIN_DOC_COMM_FACTORING).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.TX_COMM_FACTORING)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TYP_COMM_FACTORING)
                .IsRequired()
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TR_CP>(entity =>
        {
            entity.HasKey(e => e.ID_CP);

            entity.ToTable("TR_CP");

            entity.Property(e => e.CP)
                .IsRequired()
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Code_Gouvernorat)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Code_Region)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Gouvernorat)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Ville)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<TR_INT_FINANCEMENT>(entity =>
        {
            entity.HasKey(e => e.ID_TR_INT_FIN);

            entity.ToTable("TR_INT_FINANCEMENT");

            entity.Property(e => e.DAT_DEB_VALID_INT_FIN).HasColumnType("date");
            entity.Property(e => e.MAJOR_INT_INT_FIN).HasColumnType("decimal(5, 3)");
            entity.Property(e => e.PRECOMPTE_INT_FIN).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.TX_INT_MARCHE_INT_FIN).HasColumnType("decimal(5, 3)");
            entity.Property(e => e.TX_MARGE_CTR_INT_FIN).HasColumnType("decimal(5, 3)");
            entity.Property(e => e.TYP_INSTR_INT_FIN)
                .IsRequired()
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TR_LISTE_FRAIS_DIVER>(entity =>
        {
            entity.HasKey(e => e.ID_ListeFraisDivers);

            entity.ToTable("TR_LISTE_FRAIS_DIVERS");

            entity.Property(e => e.ABREV_FRAIS_DIVERS)
                .IsRequired()
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LIB_FRAIS_DIVERS)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MONT_FRAIS_DIVERS).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.TYPE_FRAIS_DIVERS)
                .HasMaxLength(20)
                .IsFixedLength();
        });

        modelBuilder.Entity<TR_LIST_VAL>(entity =>
        {
            entity.HasKey(e => e.ID_LIST_VAL).HasName("PK__TR_LIST___5D96956109A971A2");

            entity.ToTable("TR_LIST_VAL");

            entity.Property(e => e.ABR_LIST_VAL)
                .IsRequired()
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.COM_LIST_VAL)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.LIB_LIST_VAL)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TYPE_RECOUVREMENT)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TYP_LIST_VAL)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TR_NLDP>(entity =>
        {
            entity.HasKey(e => e.ID_NLDP).HasName("PK__TR_NLDP__A9D6B5AE32767D0B");

            entity.ToTable("TR_NLDP");

            entity.HasIndex(e => new { e.LIB_NT, e.ABRV_NAT, e.LIB_LANG, e.ABRV_LANG, e.LIB_DEVISE, e.ABRV_DEVISE, e.LIB_PAYS, e.ABRV_PAYS }, "UQ_NLDP").IsUnique();

            entity.Property(e => e.ABRV_DEVISE)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ABRV_LANG)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ABRV_NAT)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ABRV_PAYS)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LIB_DEVISE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LIB_LANG)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LIB_NT)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LIB_PAYS)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TR_PARAM_PIECE>(entity =>
        {
            entity.HasKey(e => e.TYP_PARAM_PIECE).HasName("PK__TR_PARAM__596D594EB71BFBC6");

            entity.ToTable("TR_PARAM_PIECE");

            entity.Property(e => e.TYP_PARAM_PIECE)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LIB_PARAM_PIECE)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.SIGN_PARAM_PIECE)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TR_RIB>(entity =>
        {
            entity.HasKey(e => e.RIB_RIB).HasName("PK__TR_RIB__2CA2FF07803A45B1");

            entity.ToTable("TR_RIB");

            entity.Property(e => e.RIB_RIB)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TR_TMM>(entity =>
        {
            entity.HasKey(e => e.ID_TMM);

            entity.ToTable("TR_TMM");

            entity.Property(e => e.DATE_DEBUT_TMM).HasColumnType("date");
            entity.Property(e => e.DATE_FIN_TMM).HasColumnType("date");
            entity.Property(e => e.TAUX_TMM).HasColumnType("decimal(6, 4)");
        });

        modelBuilder.Entity<TR_TVA>(entity =>
        {
            entity.HasKey(e => e.ID_TVA).HasName("PK__TR_TVA__27BFF8EE0D7A0286");

            entity.ToTable("TR_TVA");

            entity.Property(e => e.LIB_TVA)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VAL_TVA).HasColumnType("decimal(4, 2)");
        });

        modelBuilder.Entity<TS_GRP_USER>(entity =>
        {
            entity.HasKey(e => e.ID_GRP_USER).HasName("PK__TS_GRP_U__D6346B9A4DDCEA49");

            entity.ToTable("TS_GRP_USER");

            entity.Property(e => e.ID_GRP_USER).ValueGeneratedNever();
            entity.Property(e => e.LIB_GRP_USER)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TS_USER>(entity =>
        {
            entity.HasKey(e => e.ID_USER).HasName("PK__TS_USER__95F4844059904A2C");

            entity.ToTable("TS_USER");

            entity.HasIndex(e => e.LOGIN_USER, "UQ_USER").IsUnique();

            entity.Property(e => e.AGENCE_USER)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DIRECTION_USER)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FONCTION_USER)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LOGIN_USER)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MAIL_USER)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MDP_USER)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MOBILE_USER)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NOM_USER)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ONE_SIGNAL_PLAYER_ID)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PHOTO_USER)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PRE_USER)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SERVICE_USER)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TEL_FIXE_USER)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.ID_GRP_USERNavigation).WithMany(p => p.TS_USERs)
                .HasForeignKey(d => d.ID_GRP_USER)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TS_USER__ID_GRP___5C6CB6D7");
        });

        modelBuilder.Entity<TS_USERS_WEB>(entity =>
        {
            entity.HasKey(e => e.ID_USER_WEB);

            entity.ToTable("TS_USERS_WEB");

            entity.Property(e => e.DATE_FIN_COMPTE).HasColumnType("date");
            entity.Property(e => e.LOGIN_WEB)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LOGO_WEB)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ONE_SIGNAL_PLAYER_ID)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PASSWORD_WEB)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<T_ADRESSE>(entity =>
        {
            entity.HasKey(e => e.ID_ADR).HasName("PK__T_ADRESS__2A7CD608047AA831");

            entity.ToTable("T_ADRESSE");

            entity.Property(e => e.CP_ADR)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LIB_ADR)
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.HasOne(d => d.REF_IND_ADRNavigation).WithMany(p => p.T_ADRESSEs)
                .HasForeignKey(d => d.REF_IND_ADR)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__T_ADRESSE__REF_I__0662F0A3");
        });

        modelBuilder.Entity<T_AUTRE_F_RELELE>(entity =>
        {
            entity.HasKey(e => e.ID_AUTRE_F_REL);

            entity.ToTable("T_AUTRE_F_RELELE");

            entity.Property(e => e.ABEV_AUTRE_F_REL)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DATE_AUTRE_F_REL).HasColumnType("date");
            entity.Property(e => e.MONT_AUTRE_F_REL).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.nom_ind_AUTRE_F_REL)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<T_BCT_RCM00>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("T_BCT_RCM00");

            entity.Property(e => e.C1_RCM00).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.C2_RCM00).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.C3_RCM00).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.C4_RCM00).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.C5_RCM00).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.C6_RCM00).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.C7_RCM00).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.C8_RCM00).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.Code_RCM00)
                .IsRequired()
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Date_RCM00).HasColumnType("date");
            entity.Property(e => e.ID_RCM00).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<T_BORDEREAU>(entity =>
        {
            entity.HasKey(e => new { e.NUM_BORD, e.REF_CTR_BORD, e.ANNEE_BORD }).HasName("PK__T_BORDER__3DDB9DEBA9209E94");

            entity.ToTable("T_BORDEREAU");

            entity.Property(e => e.NUM_BORD)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ANNEE_BORD)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DAT_BORD).HasColumnType("date");
            entity.Property(e => e.DAT_SAISIE_BORD).HasColumnType("date");
            entity.Property(e => e.DEVISE_ACH)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EMETTEUR)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.MONT_TOT_BORD).HasColumnType("decimal(15, 3)");
        });

        modelBuilder.Entity<T_BORD_FACTOR>(entity =>
        {
            entity.HasKey(e => e.ID_BORD_FACTOR);

            entity.ToTable("T_BORD_FACTOR");

            entity.Property(e => e.DAT_CRE_BORD_FACTOR).HasColumnType("date");
            entity.Property(e => e.DAT_EDIT_BORD_FACTOR).HasColumnType("date");
            entity.Property(e => e.MONT_TOT_BORD_FACTOR).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.NUM_BORD_FACTOR)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.REF_ENC_BORD_FACTOR)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<T_BORD_MFG>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("T_BORD_MFG");

            entity.Property(e => e.DATE_BORD_MFG).HasColumnType("date");
            entity.Property(e => e.DATE_ENVOIE_BORD_MFG).HasColumnType("date");
            entity.Property(e => e.ID_BORD_MFG).ValueGeneratedOnAdd();
            entity.Property(e => e.MNT_COMM_HT_BORD_MFG).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.NOM_ADH_BORD_MFG)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.NUM_BORD_MFG)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<T_Bordereau_MFG>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("T_Bordereau_MFG");

            entity.Property(e => e.Date_Bord_MFG).HasColumnType("date");
            entity.Property(e => e.Date_Creation_MFG).HasColumnType("date");
            entity.Property(e => e.Date_Envoie_MFG).HasColumnType("date");
            entity.Property(e => e.ID_Bord_MFG).ValueGeneratedOnAdd();
            entity.Property(e => e.MONT_FDG_DET_MFG).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MONT_TTC_DET_MFG).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Mnt_Finanancement_MFG).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Ref_ACH_MFG)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ref_ADH_MFG)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ref_Doc_MFG)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Type_MFG)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.acc_fourn_adh_MFG).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<T_CALC_DISPO>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("T_CALC_DISPO");

            entity.Property(e => e.DATE__CALC_DISPO).HasColumnType("date");
            entity.Property(e => e.DISPO_CALC_DISPO).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.FINANCE_CALC_DISPO).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.ID_CALC_DISPO).ValueGeneratedOnAdd();
            entity.Property(e => e.INTERET_J_CALC_DISPO).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.MARGE_J_CALC_DISPO).HasColumnType("decimal(6, 4)");
            entity.Property(e => e.SOM_AVOIR_CALC_DISPO).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.SOM_COMM_FACTOR_CALC_DISPO).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.SOM_CREDIT_CALC_DISPO).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.SOM_DEBIT_CALC_DISPO).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.SOM_FACT_CALC_DISPO).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.SOM_FDG_FACT_CALC_DISPO).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.SOM_FDG_LIBERE_CALC_DISPO).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.SOM_TVA_COMM_FATOR_CALC_DISPO).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.TMM_J_CALC_DISPO).HasColumnType("decimal(6, 4)");
        });

        modelBuilder.Entity<T_CALC_INT>(entity =>
        {
            entity.HasKey(e => e.ID_CALC_INT);

            entity.ToTable("T_CALC_INT");

            entity.Property(e => e.DAT_CALC_INT).HasColumnType("date");
            entity.Property(e => e.MONT_CALC_INT).HasColumnType("decimal(15, 3)");

            entity.HasOne(d => d.REF_CTR_CALC_INTNavigation).WithMany(p => p.T_CALC_INTs)
                .HasForeignKey(d => d.REF_CTR_CALC_INT)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_T_CALC_INT_T_CONTRAT");
        });

        modelBuilder.Entity<T_CALC_INT_IR>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("T_CALC_INT_IR");

            entity.Property(e => e.Date_Echeance_IR).HasColumnType("date");
            entity.Property(e => e.ID_CALC_IR).ValueGeneratedOnAdd();
            entity.Property(e => e.MONT_CALC_IR).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.MONT_OUV_DET_BORD_IR).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.REF_DOCUMENT_DET_BORD_IR)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<T_COMMENT>(entity =>
        {
            entity.HasKey(e => e.ID_COMMENT);

            entity.ToTable("T_COMMENT");

            entity.Property(e => e.ACTION)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.COMMENT)
                .IsRequired()
                .HasMaxLength(1000);
            entity.Property(e => e.DATE_COMMENT).HasColumnType("date");
            entity.Property(e => e.DATE_TRAITE_COMMENT).HasColumnType("date");
            entity.Property(e => e.VALIDATION_TYPE)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<T_COMM_FACTORING>(entity =>
        {
            entity.HasKey(e => new { e.TYP_COMM_FACTORING, e.REF_CTR_COMM_FACTORING }).HasName("PK__T_COMM_F__C4A21010206A2EA6");

            entity.ToTable("T_COMM_FACTORING");

            entity.Property(e => e.TYP_COMM_FACTORING)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MONT_MIN_CTR_COMM_FACTORING).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.MONT_MIN_DOC_COMM_FACTORING).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.TX_COMM_FACTORING).HasColumnType("decimal(5, 3)");
        });

        modelBuilder.Entity<T_COMM_RELEVE>(entity =>
        {
            entity.HasKey(e => e.ID_COMM_RAP);

            entity.ToTable("T_COMM_RELEVE");

            entity.Property(e => e.DAT_BORD_COMM_RAP).HasColumnType("date");
            entity.Property(e => e.MONT_COMM_HT_COMM_RAP).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.MONT_COMM_TTC_COMM_RAP).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.MONT_COMM_TVA_COMM_RAP).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.REF_CTR_COMM_RAP)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TVA_COMM_RAP).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.num_bord_COMM_RAP)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<T_COMPTE>(entity =>
        {
            entity.HasKey(e => new { e.ID_COMPT, e.ID_CIR });

            entity.ToTable("T_COMPTE");

            entity.Property(e => e.DAT_CPT).HasColumnType("date");
            entity.Property(e => e.DEPASS_LIM_CPT).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.DEVISE_ACH_CPT)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FDG_REL_FACT_CPT).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.LIM_FIN_ACH_ADH).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.MODE_REG_CPT)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TOT_FACT_CPT).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.TOT_IMP_CPT).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.TOT_LIT_CPT).HasColumnType("decimal(15, 3)");
        });

        modelBuilder.Entity<T_CONFIGURATION_EMAIL>(entity =>
        {
            entity.ToTable("T_CONFIGURATION_EMAIL");

            entity.Property(e => e.EMAIL)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.MDP)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SMTP)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<T_CONTACT>(entity =>
        {
            entity.HasKey(e => e.ID_CONTACT).HasName("PK__T_CONTAC__D7288A5A1844C16F");

            entity.ToTable("T_CONTACT");

            entity.Property(e => e.FAX_CONTACT)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.MAIL1_COONTACT)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.MAIL2_COONTACT)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.NOM_PRE_CONTACT)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.POS_CONTACT)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TEL1_CONTACT)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TEL2_CONTACT)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<T_CONTACT_FACTOR>(entity =>
        {
            entity.HasKey(e => e.ID_CONTACT);

            entity.ToTable("T_CONTACT_FACTOR");

            entity.Property(e => e.FAX_CONTACT)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MAIL1_CONTACT)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MAIL2_CONTACT)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NOM_PRE_CONTACT)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.POS_CONTACT)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TEL1_CONTACT)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TEL2_CONTACT)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<T_CONTRAT>(entity =>
        {
            entity.HasKey(e => e.REF_CTR).HasName("PK__T_CONTRA__C374064F18EBB532");

            entity.ToTable("T_CONTRAT");

            entity.Property(e => e.CA_CTR).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.CA_EXP_CTR).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.CA_IMP_CTR).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.DAT_CREATION_CTR).HasColumnType("date");
            entity.Property(e => e.DAT_DEB_CTR).HasColumnType("date");
            entity.Property(e => e.DAT_PROCH_VERS_CTR).HasColumnType("date");
            entity.Property(e => e.DAT_RESIL_CTR).HasColumnType("date");
            entity.Property(e => e.DAT_SIGN_CTR).HasColumnType("date");
            entity.Property(e => e.DERN_MONT_DISP_2).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.DEVISE_CTR)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LIM_FIN_CTR).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.MIN_COMM_FACT).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.OLD_STATUT_CTR)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.REF_CTR_PAPIER_CTR)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.STATUT_CTR)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TYP_CTR)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<T_Comm_MFG>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("T_Comm_MFG");

            entity.Property(e => e.Code_MFG)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Date_Envoie_MFG).HasColumnType("date");
            entity.Property(e => e.Id_MFG).ValueGeneratedOnAdd();
            entity.Property(e => e.Mnt_Comm_MFG).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Ref_ADH_MFG)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Type_Action_MFG)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Type_MFG)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.date_Saisie_MFG).HasColumnType("date");
        });

        modelBuilder.Entity<T_DEM_FIN_CREDIT>(entity =>
        {
            entity.HasKey(e => e.ID_DEM_FIN_CREDIT).HasName("PK__T_DEM_FI__0B18FF0A093F5D4E");

            entity.ToTable("T_DEM_FIN_CREDIT");

            entity.Property(e => e.DAT_CREDIT_ACC).HasColumnType("date");
            entity.Property(e => e.DAT_FIN_ACC).HasColumnType("date");
            entity.Property(e => e.MONT_CREDIT_ACC).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.MONT_CREDIT_DEM).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.MONT_FIN_ACC).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.MONT_FIN_DEM).HasColumnType("decimal(15, 3)");
        });

        modelBuilder.Entity<T_DEM_LIMITE>(entity =>
        {
            entity.HasKey(e => new { e.REF_DEM_LIM, e.REF_CTR_DEM_LIM }).HasName("PK_T_DEM_LIMITE_1");

            entity.ToTable("T_DEM_LIMITE");

            entity.Property(e => e.REF_DEM_LIM).ValueGeneratedOnAdd();
            entity.Property(e => e.DATLIM_DEM_LIM).HasColumnType("date");
            entity.Property(e => e.DAT_ANNUL_DEM_LIM).HasColumnType("date");
            entity.Property(e => e.DAT_DEM_LIM).HasColumnType("date");
            entity.Property(e => e.DAT_LAST_DEM_LIM).HasColumnType("date");
            entity.Property(e => e.DECISION_LIM)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DEVISE)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MODE_PAY_ACC)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MODE_PAY_DEM_LIM)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MONT_ACC).HasColumnType("decimal(17, 3)");
            entity.Property(e => e.MONT_DEM_LIM).HasColumnType("decimal(17, 3)");
            entity.Property(e => e.MONT_LIM_ACH_ADH).HasColumnType("decimal(17, 3)");
            entity.Property(e => e.SORT_DEM_LIM)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TYP_DEM_LIM)
                .IsRequired()
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<T_DET_ASS>(entity =>
        {
            entity.HasKey(e => e.REF_ASS);

            entity.ToTable("T_DET_ASS");

            entity.Property(e => e.PRIME_ASS).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.TX_COUVERTURE_ASS).HasColumnType("decimal(15, 3)");
        });

        modelBuilder.Entity<T_DET_BORD>(entity =>
        {
            entity.HasKey(e => new { e.ID_DET_BORD, e.REF_CTR_DET_BORD }).HasName("PK__T_DET_BO__B2C9266D6319B466");

            entity.ToTable("T_DET_BORD");

            entity.Property(e => e.ID_DET_BORD)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ANNEE_BORD)
                .IsRequired()
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.COMM_DET_BORD).HasMaxLength(255);
            entity.Property(e => e.DAT_DET_BORD).HasColumnType("date");
            entity.Property(e => e.DEVISE_DET_BORD)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ECH_APR_PROROG_DET_BORD).HasColumnType("date");
            entity.Property(e => e.MODE_REG_DET_BORD)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MONT_COMM_FACT_DET_BORD).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.MONT_FDG_DET_BORD).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.MONT_FDG_LIBERE_DET_BORD).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.MONT_OUV_DET_BORD).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.MONT_TTC_COMM_FACT_DET_BORD).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.MONT_TTC_DET_BORD).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.MONT_TVA_COMM_FACT_DET_BORD).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.NUM_BORD)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NUM_CREANCE_ASS_BORD)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.REF_DET_BORD)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RETENU_DET_BORD).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.TX_COMM_FACT_DET_BORD).HasColumnType("decimal(6, 4)");
            entity.Property(e => e.TX_FDG_DET_BORD).HasColumnType("decimal(5, 3)");
            entity.Property(e => e.TX_TVA_COMM_FACT_DET_BORD).HasColumnType("decimal(5, 3)");
            entity.Property(e => e.TYP_ASS_DET_BORD)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TYP_DET_BORD)
                .IsRequired()
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TYP_REG_DET_BORD)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.REF_CTR_DET_BORDNavigation).WithMany(p => p.T_DET_BORDs)
                .HasForeignKey(d => d.REF_CTR_DET_BORD)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__T_DET_BOR__REF_C__6501FCD8");
        });

        modelBuilder.Entity<T_DOC_GED>(entity =>
        {
            entity.ToTable("T_DOC_GED");

            entity.Property(e => e.ADRESS_DOC_GED)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Archive_GED)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Armoire_GED)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DATE_SCAN_GED).HasColumnType("datetime");
            entity.Property(e => e.DATE_TACHE_GED).HasColumnType("datetime");
            entity.Property(e => e.Etape_ged)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Etgage_GED)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ID_Emetteur_GED)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LIBELLE2_GED)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.LIBELLE_GED)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name_GED)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.salle_GED)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<T_DOC_PHYSIQUE>(entity =>
        {
            entity.HasKey(e => new { e.TYP_DOC_PHY, e.REF_CTR_DOC_PHY }).HasName("PK__T_DOC_PH__47E98F6E7A3223E8");

            entity.ToTable("T_DOC_PHYSIQUE");

            entity.Property(e => e.TYP_DOC_PHY)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DAT_EXPIR_DOC_PHY).HasColumnType("date");
            entity.Property(e => e.DAT_VALID_DOC_PHY).HasColumnType("date");
            entity.Property(e => e.REF_USER_DOC_PHY)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<T_Det_Achat_RELEVE>(entity =>
        {
            entity.HasKey(e => e.ID_Det_Achat_REL);

            entity.ToTable("T_Det_Achat_RELEVE");

            entity.Property(e => e.DAT_BORD_Det_Achat_REL).HasColumnType("date");
            entity.Property(e => e.DAT_DET_BORD_Det_Achat_REL).HasColumnType("date");
            entity.Property(e => e.DAT_ECHEANCE_Det_Achat_REL).HasColumnType("date");
            entity.Property(e => e.MONT_TTC_COMM_Det_Achat_REL).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.MONT_TTC_Det_Achat_REL).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.TX_COMM_Det_Achat_REL).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.TYP_DET_BORD_Det_Achat_REL)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.nom_ind_Det_Achat_REL)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.num_bord_Det_Achat_REL)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ref_document_Det_Achat_REL)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<T_EC_COMPTABLE>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("T_EC_COMPTABLE");

            entity.Property(e => e.CODE_ENT_EC_CPT)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.COD_JOURNAL_EC_CPT)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.DAT_EFF_EC_CPT).HasColumnType("date");
            entity.Property(e => e.DAT_SAIS_EC_CPT).HasColumnType("date");
            entity.Property(e => e.DECS_SRC_CG_EC_CPT)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.DESC_EC_CPT)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.DEVISE_EC_CPT)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.DOMAINE_EC_CPT)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.ID_USER_EC_EPT)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.LOT_EC_CPT)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.MONT_EC_CPT).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.REF_EC_CPT)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.SEQ_COD_JOURNAL_EC_CPT)
                .HasMaxLength(9)
                .IsFixedLength();
            entity.Property(e => e.TYP_DOC_EC_CPT)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.TYP_TR_EC_CPT)
                .HasMaxLength(8)
                .IsUnicode(false);
        });

        modelBuilder.Entity<T_EC_CPT>(entity =>
        {
            entity.HasKey(e => e.ID_ECCPT);

            entity.ToTable("T_EC_CPT");

            entity.Property(e => e.CODE_CENTRE_ANALYSE_EC_CPT)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.CODE_DEP_EC_CPT)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CODE_EC_CPT)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CODE_JOURNAL_EC_CPT)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.CODE_TIERS_EC_CPT)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.COMPTE_EC_CPT)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.COMPTE_GEN_EC_CPT)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CREDIT_EC_CPT).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.DATE_EC_CPT).HasColumnType("date");
            entity.Property(e => e.DATE_EFFET_EC_CPT).HasColumnType("date");
            entity.Property(e => e.DATE_SAISIE_EC_CPT).HasColumnType("date");
            entity.Property(e => e.DOMAINE_EC_CPT)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.INTITULE_EC_CPT)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LIBELLEE_EC_CPT)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LOT_EC_CPT)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MONTANT_EC_CPT).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.NOM_USER_EC_CPT)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NUM_EC_EC_CPT)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.REF_MFG_ADH_EC_CPT)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.REF_PIECE_EC_CPT)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TYPE_DOC_EC_CPT)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.TYPE_TRANSACTION_EC_CPT)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<T_EMAIL>(entity =>
        {
            entity.HasKey(e => new { e.ID_USER, e.TITRE_GROUPE });

            entity.ToTable("T_EMAIL");

            entity.Property(e => e.TITRE_GROUPE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ID_EMAIL).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<T_ENCAISSEMENT>(entity =>
        {
            entity.HasKey(e => e.ID_ENC).HasName("PK__T_ENCAIS__2D4C367D67DE6983");

            entity.ToTable("T_ENCAISSEMENT");

            entity.Property(e => e.BORD_ENC)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DAT_RECEP_ENC).HasColumnType("date");
            entity.Property(e => e.DAT_VAL_ENC).HasColumnType("date");
            entity.Property(e => e.DEVISE_ENC)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MONT_ENC).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.REF_ENC)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.REF_SEQ_ENC)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.RIB_ENC)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.TYP_ENC)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<T_ETAT_DISPO>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("T_ETAT_DISPO");

            entity.Property(e => e.Date_ETAT_DISPO).HasColumnType("date");
            entity.Property(e => e.Depass_Limite_ETAT_DISPO).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.Disponible_ETAT_DISPO).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.ID_ETAT_DISPO).ValueGeneratedOnAdd();
            entity.Property(e => e.Total_Av_ETAT_DISPO).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.Total_Comm_ETAT_DISPO).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.Total_Credit_ETAT_DISPO).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.Total_Debit_ETAT_DISPO).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.Total_Disponible_2_ETAT_DISPO).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.Total_Encours_Facture_ETAT_DISPO).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.Total_FDG_ETAT_DISPO).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.Total_Facture_ETAT_DISPO).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.Total_Fin_ETAT_DISPO).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.Total_Financement_du_mois_ETAT_DISPO).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.Total_Fonds_Reserve_ETAT_DISPO).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.Total_Frais_ETAT_DISPO).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.Total_IR_ETAT_DIPOS).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.Total_Instru_Paiments_Imp_ETAT_DIPOS).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.Total_Interet_ETAT_DISPO).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.Total_Litiges_ouvert_ETAT_DISPO).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.Total_Retard_Paiement_Algo_ETAT_DISPO).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.Total_Retenue_ETAT_DISPO).HasColumnType("decimal(15, 3)");
        });

        modelBuilder.Entity<T_EXTRAIT>(entity =>
        {
            entity.HasKey(e => e.ID_EXTRAIT);

            entity.ToTable("T_EXTRAIT");

            entity.Property(e => e.AUTRE_EXTRAIT).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.CREDIT_EXTRAIT).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.DAT_OP_EXTRAIT).HasColumnType("datetime");
            entity.Property(e => e.DAT_VAL_EXTRAIT).HasColumnType("datetime");
            entity.Property(e => e.DEBIT_EXTRAIT).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.DISPONIBLE_EXTRAIT).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.ENCOURFACT_EXTRAIT).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.FDG_EXTRAIT).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.LIB_EXTRAIT)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.TOTAL_FIN_EXTRAIT).HasColumnType("decimal(15, 3)");
        });

        modelBuilder.Entity<T_FACTOR>(entity =>
        {
            entity.HasKey(e => e.ID_FACTOR);

            entity.ToTable("T_FACTOR");

            entity.Property(e => e.ABRV)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ADRESSE)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CAPITAL)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CAPITAL_LETTRE)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CNX_DB)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CODE_DOUANE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CODE_TVA)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DB)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DEVISE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EMAIL)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EXERCICE)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.FAX)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LANGUE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MDP_CNX)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MF)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PAYS)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RAISON_SOCIAL)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.RC)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SITE_WEB)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SRV_DB)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TEL)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<T_FINANCEMENT>(entity =>
        {
            entity.HasKey(e => e.ID_FIN).HasName("PK_T_FINANCEMENT_5");

            entity.ToTable("T_FINANCEMENT");

            entity.Property(e => e.DAT_FIN).HasColumnType("date");
            entity.Property(e => e.DAT_INSTR_FIN).HasColumnType("date");
            entity.Property(e => e.ETAT_FIN)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.INSTR_FIN)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MONT_FIN).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.REF_INSTR_FIN)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TYPE_ENC)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<T_FOND_GARANTIE>(entity =>
        {
            entity.HasKey(e => new { e.REF_CTR_FDG, e.TYP_FDG }).HasName("PK__T_FOND_G__CD7BEB41B71B42C1");

            entity.ToTable("T_FOND_GARANTIE");

            entity.Property(e => e.TYP_FDG)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LIB_FDG)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MONT_MAX_FDG).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.MONT_MIN_FDG).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.TX_FDG).HasColumnType("decimal(5, 3)");
            entity.Property(e => e.TYP_DOC_REMIS_FDG)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<T_FRAIS_DIVER>(entity =>
        {
            entity.HasKey(e => new { e.TYP_FRAIS_DIVERS, e.REF_CTR_FRAIS_DIVERS }).HasName("PK__T_FRAIS___B72D5284465B0E76");

            entity.ToTable("T_FRAIS_DIVERS");

            entity.Property(e => e.TYP_FRAIS_DIVERS)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LIB_FRAIS_DIVERS)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MONT_PAR_UNIT_FRAIS_DIVERS).HasColumnType("decimal(15, 3)");
        });

        modelBuilder.Entity<T_FRAIS_PAIEMENT>(entity =>
        {
            entity.HasKey(e => new { e.TYP_FRAIS_PAIE, e.REF_CTR_FRAIS_PAIE }).HasName("PK__T_FRAIS___D572DF09CAE41C88");

            entity.ToTable("T_FRAIS_PAIEMENT");

            entity.Property(e => e.TYP_FRAIS_PAIE)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LIB_FRAIS_PAIE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MONT_PAR_INSTR_FRAIS_PAIE).HasColumnType("decimal(15, 3)");
        });

        modelBuilder.Entity<T_FRAIS_RELEVE>(entity =>
        {
            entity.HasKey(e => e.ID_FRAIS_REL);

            entity.ToTable("T_FRAIS_RELEVE");

            entity.Property(e => e.MNTTTCT).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.MONT_PAR_INSTR_FRAIS_PAIE).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.TAXTVA).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.TTCPP).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.TVA).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.dat_recep_enc).HasColumnType("date");
            entity.Property(e => e.typ_enc)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<T_Fichiers_Scan>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("T_Fichiers_Scan");

            entity.Property(e => e.Adresse_Scan)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Affect_Scan)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Date_Scan).HasColumnType("date");
            entity.Property(e => e.Id_Scan).ValueGeneratedOnAdd();
            entity.Property(e => e.Nom_Fichier_SansEXT)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Nom_Fichier_Scan)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<T_GROUPE>(entity =>
        {
            entity.HasKey(e => e.ID_GROUP);

            entity.ToTable("T_GROUPE");

            entity.Property(e => e.NOM_GROUP)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<T_HISTORIQUE>(entity =>
        {
            entity.HasKey(e => e.ID_HISTORIQUEE);

            entity.ToTable("T_HISTORIQUE");

            entity.Property(e => e.ABREV_ROLE_HIST)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.ACTION)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DATE_ACTION).HasColumnType("datetime");
            entity.Property(e => e.ID_ENREGISTREMENT)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IP_PC)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LOGIN_USER)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NOM_PC)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.REF_CTR_HIST)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.REF_IND_HIST)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.T_TABLE)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<T_IMPAYE>(entity =>
        {
            entity.HasKey(e => e.ID_IMP);

            entity.ToTable("T_IMPAYE");

            entity.Property(e => e.DATE_IMP).HasColumnType("date");
            entity.Property(e => e.DATE_RESOL_IMP).HasColumnType("date");
            entity.Property(e => e.DATE_SAISI_IMP).HasColumnType("date");
            entity.Property(e => e.ID_NV_ENCS).IsUnicode(false);
            entity.Property(e => e.MONT_IMP).HasColumnType("decimal(15, 3)");
        });

        modelBuilder.Entity<T_INDIVIDU>(entity =>
        {
            entity.HasKey(e => e.REF_IND).HasName("PK__T_INDIVI__C2FC383A7073AF84");

            entity.ToTable("T_INDIVIDU");

            entity.HasIndex(e => new { e.NOM_IND, e.PRE_IND }, "UQ_NOM_PRENOM").IsUnique();

            entity.Property(e => e.ABRV_IND)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ADR_IND)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.COD_SCLAS).HasMaxLength(255);
            entity.Property(e => e.COD_TVA_IND)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CP_IND)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DATE_DOC_ID_IND).HasColumnType("date");
            entity.Property(e => e.DAT_DEB_EXO).HasColumnType("date");
            entity.Property(e => e.DAT_FIN_EXO).HasColumnType("date");
            entity.Property(e => e.DAT_INFO_IND).HasColumnType("date");
            entity.Property(e => e.DAT_NAISS_CREAT).HasColumnType("date");
            entity.Property(e => e.EMAIL_IND)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FAX_IND)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FROM_JUR_IND)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.GENRE_IND)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.INFO_IND)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.LIEU_DOC_ID_IND)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LIM_CRED_GLO_IND).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.LIM_FIN_GLO_IND).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.MF_IND)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NOM_IND)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.NUM_DOC_ID_IND)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PRE_IND)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RC_IND)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.REF_ACH_IND)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.REF_ADH_IND)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.TEL_IND)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TYP_DOC_ID_IND)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<T_INFO_CTR>(entity =>
        {
            entity.HasKey(e => e.ID_INFO_CTR);

            entity.ToTable("T_INFO_CTR");

            entity.Property(e => e.DATE_INFO_CTR).HasColumnType("date");
            entity.Property(e => e.LIBELLE_INFO_CTR).IsUnicode(false);
        });

        modelBuilder.Entity<T_INT_FINANCEMENT>(entity =>
        {
            entity.HasKey(e => new { e.TYP_INSTR_INT_FIN, e.REF_CTR_INT_FIN }).HasName("PK__T_INT_FI__BEC6666211EF5D1D");

            entity.ToTable("T_INT_FINANCEMENT");

            entity.Property(e => e.TYP_INSTR_INT_FIN)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DAT_DEB_VALID_INT_FIN).HasColumnType("date");
            entity.Property(e => e.MAJOR_INT_INT_FIN).HasColumnType("decimal(5, 3)");
            entity.Property(e => e.PRECOMPTE_INT_FIN).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.TX_INT_MARCHE_INT_FIN).HasColumnType("decimal(5, 3)");
            entity.Property(e => e.TX_MARGE_CTR_INT_FIN).HasColumnType("decimal(5, 3)");
        });

        modelBuilder.Entity<T_LITIGE>(entity =>
        {
            entity.HasKey(e => e.ID_LITIGE).HasName("PK__T_LITIGE__66F660A1412EB0B6");

            entity.ToTable("T_LITIGE");

            entity.Property(e => e.DAT_LIT).HasColumnType("date");
            entity.Property(e => e.ECH_LIT).HasColumnType("date");
            entity.Property(e => e.MONT_LT).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.TYP_LIT)
                .IsRequired()
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<T_MOTIF_LIT>(entity =>
        {
            entity.HasKey(e => new { e.REF_CTR_MOTIF_LIT, e.TYP_MOTIF_LIT }).HasName("PK__T_MOTIF___CA7DAB520D44F85C");

            entity.ToTable("T_MOTIF_LIT");

            entity.Property(e => e.TYP_MOTIF_LIT)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LIB_MOTIF_LIT)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LOGIN_USER_MOTIF_LIT)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<T_MOTIF_PROG>(entity =>
        {
            entity.HasKey(e => new { e.TYP_MOTIF_PROG, e.REF_CTR_MOTIF_PROG }).HasName("PK__T_MOTIF___92C097C701D345B0");

            entity.ToTable("T_MOTIF_PROG");

            entity.Property(e => e.TYP_MOTIF_PROG)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DAT_MOTIF_PROG).HasColumnType("date");
            entity.Property(e => e.ECH_MOTIF_PROG).HasColumnType("date");
            entity.Property(e => e.LIB_MOTIF_PROG)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LOGIN_USER_MOTIF_PROG)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<T_MVT_CREDIT>(entity =>
        {
            entity.HasKey(e => e.ID_CREDIT);

            entity.ToTable("T_MVT_CREDIT");

            entity.Property(e => e.ABRV_CREDIT)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DATE_CREDIT).HasColumnType("date");
            entity.Property(e => e.DAT_VAL_ENC_CREDIT).HasColumnType("date");
            entity.Property(e => e.LIBELLE_LIBRE_CREDIT)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MONT_CREDIT).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.REF_ENC_CREDIT)
                .HasMaxLength(18)
                .IsUnicode(false);
            entity.Property(e => e.TYP_CREDIT)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<T_MVT_DEBIT>(entity =>
        {
            entity.HasKey(e => e.ID_DEBIT);

            entity.ToTable("T_MVT_DEBIT");

            entity.Property(e => e.ABEV_DEBIT)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DATE_DEBIT).HasColumnType("date");
            entity.Property(e => e.MONT_DEBIT).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.TYP_DEBIT)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<T_PROROGATION>(entity =>
        {
            entity.HasKey(e => e.ID_PROROGATION);

            entity.ToTable("T_PROROGATION");

            entity.Property(e => e.DAT_PROG).HasColumnType("date");
            entity.Property(e => e.ECH_PROG).HasColumnType("date");
            entity.Property(e => e.MOTIF_PROG)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TYP_PROG)
                .IsRequired()
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<T_RELANCE>(entity =>
        {
            entity.HasKey(e => e.ID_RELANCE);

            entity.ToTable("T_RELANCE");

            entity.Property(e => e.DATE_RELANCE).HasColumnType("date");
            entity.Property(e => e.LIBELLE_RELANCE)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.REF_CTR_RELANCE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.REF_DOC_RELANCE)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.USER_RELANCE)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<T_RELEVE>(entity =>
        {
            entity.HasKey(e => e.ID_RELEVE);

            entity.ToTable("T_RELEVE");

            entity.Property(e => e.ADH_RELEVE)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Contrat_RELEVE)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Credit_RELEVE).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.Date_OP_RELEVE).HasColumnType("datetime");
            entity.Property(e => e.Date_RELEVE).HasColumnType("datetime");
            entity.Property(e => e.Disponible_RELEVE)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Encours_Facture_RELEVE)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Libelle_OP_RELEVE)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PP_RELEVE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.autre_RELEVE).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.debit_RELEVE).HasColumnType("decimal(15, 3)");
        });

        modelBuilder.Entity<T_RIB_FACTOR>(entity =>
        {
            entity.HasKey(e => new { e.ID_FACTOR, e.RIB_FACTOR });

            entity.ToTable("T_RIB_FACTOR");

            entity.Property(e => e.ID_FACTOR).ValueGeneratedOnAdd();
            entity.Property(e => e.RIB_FACTOR)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<T_ROLE>(entity =>
        {
            entity.HasKey(e => e.ID_ROLE).HasName("PK__T_ROLE__C7D0F6576EC0713C");

            entity.ToTable("T_ROLE");

            entity.Property(e => e.ID_ROLE)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LIB_ROLE)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        base.OnModelCreating(modelBuilder);

        var entitiesAssembly = typeof(IEntity).Assembly;
        modelBuilder.RegisterAllEntities<IEntity>(entitiesAssembly);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        modelBuilder.AddRestrictDeleteBehaviorConvention();

    }

    private void ConfigureEntityDates()
    {
        var updatedEntities = ChangeTracker.Entries().Where(x =>
            x.Entity is ITimeModification && x.State == EntityState.Modified).Select(x => x.Entity as ITimeModification);

        var addedEntities = ChangeTracker.Entries().Where(x =>
            x.Entity is ITimeModification && x.State == EntityState.Added).Select(x => x.Entity as ITimeModification);

        foreach (var entity in updatedEntities)
        {
            if (entity != null)
            {
                entity.ModifiedDate = DateTime.Now;
            }
        }

        foreach (var entity in addedEntities)
        {
            if (entity != null)
            {
                entity.CreatedTime = DateTime.Now;
                entity.ModifiedDate = DateTime.Now;
            }
        }
    }
}