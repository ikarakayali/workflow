﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using amorphie.tag.data;

#nullable disable

namespace amorphie.workflow.data.Migrations
{
    [DbContext(typeof(WorkflowDBContext))]
    partial class WorkflowDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("State", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("BaseStatus")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedByBehalfOf")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ModifiedByBehalfOf")
                        .HasColumnType("uuid");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<string>("WorkflowName")
                        .HasColumnType("text");

                    b.HasKey("Name");

                    b.HasIndex("WorkflowName");

                    b.ToTable("State");

                    b.HasData(
                        new
                        {
                            Name = "retail-loan-start",
                            BaseStatus = 2,
                            CreatedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8380),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            ModifiedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8380),
                            ModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Type = 100,
                            WorkflowName = "retail-loan"
                        },
                        new
                        {
                            Name = "retail-loan-finish",
                            BaseStatus = 2,
                            CreatedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8450),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            ModifiedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8450),
                            ModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Type = 200,
                            WorkflowName = "retail-loan"
                        });
                });

            modelBuilder.Entity("Transition", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedByBehalfOf")
                        .HasColumnType("uuid");

                    b.Property<string>("Form")
                        .HasColumnType("text");

                    b.Property<string>("FromStateName")
                        .HasColumnType("text");

                    b.Property<string>("Gateway")
                        .HasColumnType("text");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ModifiedByBehalfOf")
                        .HasColumnType("uuid");

                    b.Property<string>("Process")
                        .HasColumnType("text");

                    b.Property<string>("ToStateName")
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Name");

                    b.HasIndex("FromStateName");

                    b.HasIndex("ToStateName");

                    b.ToTable("Transition");
                });

            modelBuilder.Entity("Translation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedByBehalfOf")
                        .HasColumnType("uuid");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ModifiedByBehalfOf")
                        .HasColumnType("uuid");

                    b.Property<string>("StateName_Description")
                        .HasColumnType("text");

                    b.Property<string>("StateName_Title")
                        .HasColumnType("text");

                    b.Property<string>("WorkflowName_Title")
                        .HasColumnType("text");

                    b.Property<string>("WorkflowName_Transition")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("StateName_Description");

                    b.HasIndex("StateName_Title");

                    b.HasIndex("WorkflowName_Title");

                    b.HasIndex("WorkflowName_Transition");

                    b.ToTable("Translation");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d08f0ddc-1e7e-403a-9aa9-95bbd575a561"),
                            CreatedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8360),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Label = "Bireysel Kredi Sureci",
                            Language = "tr-TR",
                            ModifiedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8360),
                            ModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            WorkflowNameTitle = "retail-loan"
                        },
                        new
                        {
                            Id = new Guid("34490288-4d0e-42f2-bfd9-0e8c06038158"),
                            CreatedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8370),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Label = "Retail Loan Process",
                            Language = "en-EN",
                            ModifiedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8370),
                            ModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            WorkflowNameTitle = "retail-loan"
                        },
                        new
                        {
                            Id = new Guid("e3b8f29d-c9d3-4400-87e2-3abe6e87d5eb"),
                            CreatedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8400),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Label = "Akis Baslangic Asamasi",
                            Language = "tr-TR",
                            ModifiedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8400),
                            ModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            StateNameTitle = "retail-loan-start"
                        },
                        new
                        {
                            Id = new Guid("dc0566fa-edc7-4309-8e30-bc8e8a37ce2a"),
                            CreatedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8410),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Label = "Start State",
                            Language = "en-EN",
                            ModifiedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8410),
                            ModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            StateNameTitle = "retail-loan-start"
                        },
                        new
                        {
                            Id = new Guid("7f564577-ff09-4de3-b7c5-ddb2b599605b"),
                            CreatedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8430),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Label = "Kredi sureci akis Baslangic Asamasi",
                            Language = "tr-TR",
                            ModifiedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8430),
                            ModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            StateNameDescription = "retail-loan-start"
                        },
                        new
                        {
                            Id = new Guid("46fa303d-1e0f-4c4c-91d2-08b17e816157"),
                            CreatedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8440),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Label = "Retail Loan Start State",
                            Language = "en-EN",
                            ModifiedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8440),
                            ModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            StateNameDescription = "retail-loan-start"
                        },
                        new
                        {
                            Id = new Guid("532d3364-68ad-463c-9021-bd6bc840a5dc"),
                            CreatedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8460),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Label = "Akis bitis asamasi",
                            Language = "tr-TR",
                            ModifiedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8460),
                            ModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            StateNameTitle = "retail-loan-finish"
                        },
                        new
                        {
                            Id = new Guid("c99d71d4-5d3d-4ec1-a538-9130e5ad5f3b"),
                            CreatedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8470),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Label = "Finish state",
                            Language = "en-EN",
                            ModifiedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8480),
                            ModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            StateNameTitle = "retail-loan-finish"
                        },
                        new
                        {
                            Id = new Guid("aa0c8a66-d7ed-453f-a5ba-d06742791244"),
                            CreatedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8490),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Label = "Kredi sureci akis bitis asamasi",
                            Language = "tr-TR",
                            ModifiedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8490),
                            ModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            StateNameDescription = "retail-loan-finish"
                        },
                        new
                        {
                            Id = new Guid("4aa21cb1-be6b-4ae5-a349-66c664ee6e20"),
                            CreatedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8500),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Label = "Retail loan finis state",
                            Language = "en-EN",
                            ModifiedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8500),
                            ModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            StateNameDescription = "retail-loan-finish"
                        },
                        new
                        {
                            Id = new Guid("f1fd0afa-b3ec-47bf-825b-22e1dbb106b9"),
                            CreatedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8520),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Label = "Kullanici Statu Akisi",
                            Language = "tr-TR",
                            ModifiedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8520),
                            ModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            WorkflowNameTitle = "user-lifecyle"
                        },
                        new
                        {
                            Id = new Guid("0aaab74e-ed62-407b-bfb5-17d5dd133b60"),
                            CreatedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8540),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Label = "User State Process",
                            Language = "en-EN",
                            ModifiedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8540),
                            ModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            WorkflowNameTitle = "user-lifecyle"
                        });
                });

            modelBuilder.Entity("Workflow", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedByBehalfOf")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ModifiedByBehalfOf")
                        .HasColumnType("uuid");

                    b.Property<string[]>("Tags")
                        .HasColumnType("text[]");

                    b.Property<string>("ZeebeFlowName")
                        .HasColumnType("text");

                    b.HasKey("Name");

                    b.HasIndex("ZeebeFlowName");

                    b.ToTable("Workflows");

                    b.HasData(
                        new
                        {
                            Name = "retail-loan",
                            CreatedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8250),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            ModifiedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8250),
                            ModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Tags = new[] { "retail", "loan" }
                        },
                        new
                        {
                            Name = "user-lifecyle",
                            CreatedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8510),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            ModifiedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8510),
                            ModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Tags = new[] { "idm", "user" }
                        });
                });

            modelBuilder.Entity("WorkflowEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AvailableInStatus")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedByBehalfOf")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsExclusive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsStateManager")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ModifiedByBehalfOf")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("WorkflowName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("WorkflowName");

                    b.ToTable("WorkflowEntity");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7a8bcec7-8474-4c64-87d3-962b44423f58"),
                            AvailableInStatus = 30,
                            CreatedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8550),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsExclusive = false,
                            IsStateManager = true,
                            ModifiedAt = new DateTime(2023, 2, 12, 13, 43, 55, 454, DateTimeKind.Utc).AddTicks(8550),
                            ModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "user",
                            WorkflowName = "user-lifecyle"
                        });
                });

            modelBuilder.Entity("ZeebeFlow", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedByBehalfOf")
                        .HasColumnType("uuid");

                    b.Property<string>("Gateway")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsAtomic")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ModifiedByBehalfOf")
                        .HasColumnType("uuid");

                    b.Property<string>("Process")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string[]>("Tags")
                        .HasColumnType("text[]");

                    b.HasKey("Name");

                    b.ToTable("ZeebeFlow");
                });

            modelBuilder.Entity("State", b =>
                {
                    b.HasOne("Workflow", "Workflow")
                        .WithMany("States")
                        .HasForeignKey("WorkflowName");

                    b.Navigation("Workflow");
                });

            modelBuilder.Entity("Transition", b =>
                {
                    b.HasOne("State", "FromState")
                        .WithMany("Transitions")
                        .HasForeignKey("FromStateName");

                    b.HasOne("State", "ToState")
                        .WithMany()
                        .HasForeignKey("ToStateName");

                    b.Navigation("FromState");

                    b.Navigation("ToState");
                });

            modelBuilder.Entity("Translation", b =>
                {
                    b.HasOne("State", null)
                        .WithMany("Description")
                        .HasForeignKey("StateName_Description");

                    b.HasOne("State", null)
                        .WithMany("Title")
                        .HasForeignKey("StateName_Title");

                    b.HasOne("Workflow", null)
                        .WithMany("Titles")
                        .HasForeignKey("WorkflowName_Title");

                    b.HasOne("Transition", null)
                        .WithMany("Title")
                        .HasForeignKey("WorkflowName_Transition");
                });

            modelBuilder.Entity("Workflow", b =>
                {
                    b.HasOne("ZeebeFlow", "ZeebeFlow")
                        .WithMany()
                        .HasForeignKey("ZeebeFlowName");

                    b.Navigation("ZeebeFlow");
                });

            modelBuilder.Entity("WorkflowEntity", b =>
                {
                    b.HasOne("Workflow", "Workflow")
                        .WithMany("Entities")
                        .HasForeignKey("WorkflowName");

                    b.Navigation("Workflow");
                });

            modelBuilder.Entity("State", b =>
                {
                    b.Navigation("Description");

                    b.Navigation("Title");

                    b.Navigation("Transitions");
                });

            modelBuilder.Entity("Transition", b =>
                {
                    b.Navigation("Title");
                });

            modelBuilder.Entity("Workflow", b =>
                {
                    b.Navigation("Entities");

                    b.Navigation("States");

                    b.Navigation("Titles");
                });
#pragma warning restore 612, 618
        }
    }
}
