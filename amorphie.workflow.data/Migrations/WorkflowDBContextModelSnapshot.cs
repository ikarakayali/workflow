﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using NpgsqlTypes;

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
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Instance", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("BaseStatus")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedByBehalfOf")
                        .HasColumnType("uuid");

                    b.Property<string>("EntityName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ModifiedByBehalfOf")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RecordId")
                        .HasColumnType("uuid");

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("WorkflowName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ZeebeFlowName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("StateName");

                    b.HasIndex("WorkflowName");

                    b.HasIndex("ZeebeFlowName");

                    b.HasIndex("EntityName", "RecordId", "StateName");

                    b.ToTable("Instances");
                });

            modelBuilder.Entity("InstanceEvent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AdditionalData")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CompletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedByBehalfOf")
                        .HasColumnType("uuid");

                    b.Property<int>("Duration")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ExecutedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("InputData")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("InstanceTransitionId")
                        .HasColumnType("uuid");

                    b.Property<string>("OutputData")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("InstanceTransitionId");

                    b.ToTable("InstanceEvents");
                });

            modelBuilder.Entity("InstanceTransition", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AdditionalData")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedByBehalfOf")
                        .HasColumnType("uuid");

                    b.Property<string>("EntityData")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("FinishedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FormData")
                        .HasColumnType("text");

                    b.Property<string>("FromStateName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("HeadersData")
                        .HasColumnType("text");

                    b.Property<Guid>("InstanceId")
                        .HasColumnType("uuid");

                    b.Property<string>("QueryData")
                        .HasColumnType("text");

                    b.Property<string>("RouteData")
                        .HasColumnType("text");

                    b.Property<DateTime?>("StartedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ToStateName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TransitionName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FromStateName");

                    b.HasIndex("InstanceId");

                    b.HasIndex("ToStateName");

                    b.HasIndex("TransitionName");

                    b.ToTable("InstanceTransitions");
                });

            modelBuilder.Entity("Page", b =>
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

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ModifiedByBehalfOf")
                        .HasColumnType("uuid");

                    b.Property<int>("Operation")
                        .HasColumnType("integer");

                    b.Property<int?>("Timeout")
                        .HasColumnType("integer");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("PageComponent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ComponentJson")
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

                    b.Property<Guid?>("PageId")
                        .HasColumnType("uuid");

                    b.Property<string>("PageName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<NpgsqlTsVector>("SearchVector")
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("tsvector")
                        .HasComputedColumnSql("to_tsvector('english', coalesce(\"PageName\", ''))", true);

                    b.HasKey("Id");

                    b.HasIndex("PageId");

                    b.HasIndex("SearchVector");

                    NpgsqlIndexBuilderExtensions.HasMethod(b.HasIndex("SearchVector"), "GIN");

                    b.ToTable("PageComponents");
                });

            modelBuilder.Entity("PageComponentUiModel", b =>
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

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ModifiedByBehalfOf")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("PageComponentUiModels");
                });

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

                    b.Property<bool?>("IsPublicForm")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ModifiedByBehalfOf")
                        .HasColumnType("uuid");

                    b.Property<string>("OnEntryFlowName")
                        .HasColumnType("text");

                    b.Property<string>("OnExitFlowName")
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<string>("WorkflowName")
                        .HasColumnType("text");

                    b.HasKey("Name");

                    b.HasIndex("OnEntryFlowName");

                    b.HasIndex("OnExitFlowName");

                    b.HasIndex("WorkflowName");

                    b.ToTable("States");
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

                    b.Property<string>("FlowName")
                        .HasColumnType("text");

                    b.Property<string>("FromStateName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ModifiedByBehalfOf")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("PageId")
                        .HasColumnType("uuid");

                    b.Property<string>("ServiceName")
                        .HasColumnType("text");

                    b.Property<string>("ToStateName")
                        .HasColumnType("text");

                    b.Property<int?>("TypeofUi")
                        .HasColumnType("integer");

                    b.Property<bool?>("requireData")
                        .HasColumnType("boolean");

                    b.Property<int?>("transitionButtonType")
                        .HasColumnType("integer");

                    b.HasKey("Name");

                    b.HasIndex("FlowName");

                    b.HasIndex("FromStateName");

                    b.HasIndex("PageId");

                    b.HasIndex("ToStateName");

                    b.ToTable("Transitions");
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

                    b.Property<Guid?>("RecordId")
                        .HasColumnType("uuid");

                    b.Property<NpgsqlTsVector>("SearchVector")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("tsvector")
                        .HasComputedColumnSql("to_tsvector('english', coalesce(\"Name\", ''))", true);

                    b.Property<string[]>("Tags")
                        .HasColumnType("text[]");

                    b.Property<Guid?>("WorkflowEntityId")
                        .HasColumnType("uuid");

                    b.Property<int?>("WorkflowStatus")
                        .HasColumnType("integer");

                    b.Property<string>("ZeebeFlowName")
                        .HasColumnType("text");

                    b.HasKey("Name");

                    b.HasIndex("SearchVector");

                    NpgsqlIndexBuilderExtensions.HasMethod(b.HasIndex("SearchVector"), "GIN");

                    b.HasIndex("WorkflowEntityId");

                    b.HasIndex("ZeebeFlowName");

                    b.ToTable("Workflows");
                });

            modelBuilder.Entity("WorkflowEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("AllowOnlyOneActiveInstance")
                        .HasColumnType("boolean");

                    b.Property<int>("AvailableInStatus")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedByBehalfOf")
                        .HasColumnType("uuid");

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
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("WorkflowName");

                    b.ToTable("WorkflowEntities");
                });

            modelBuilder.Entity("ZeebeMessage", b =>
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

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("text");

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

                    b.ToTable("ZeebeMessages");
                });

            modelBuilder.Entity("amorphie.core.Base.Translation", b =>
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

                    b.Property<Guid?>("PageComponentUiModelId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("PageId_Page")
                        .HasColumnType("uuid");

                    b.Property<string>("StateName_Description")
                        .HasColumnType("text");

                    b.Property<string>("StateName_PublicForm")
                        .HasColumnType("text");

                    b.Property<string>("StateName_Title")
                        .HasColumnType("text");

                    b.Property<string>("TransitionName_Form")
                        .HasColumnType("text");

                    b.Property<string>("TransitionName_HistoryForm")
                        .HasColumnType("text");

                    b.Property<string>("TransitionName_Page")
                        .HasColumnType("text");

                    b.Property<string>("TransitionName_Title")
                        .HasColumnType("text");

                    b.Property<Guid?>("UiForm_Id")
                        .HasColumnType("uuid");

                    b.Property<string>("WorkflowName_HistoryForm")
                        .HasColumnType("text");

                    b.Property<string>("WorkflowName_Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PageComponentUiModelId");

                    b.HasIndex("PageId_Page");

                    b.HasIndex("StateName_Description");

                    b.HasIndex("StateName_PublicForm");

                    b.HasIndex("StateName_Title");

                    b.HasIndex("TransitionName_Form");

                    b.HasIndex("TransitionName_HistoryForm");

                    b.HasIndex("TransitionName_Page");

                    b.HasIndex("TransitionName_Title");

                    b.HasIndex("UiForm_Id");

                    b.HasIndex("WorkflowName_HistoryForm");

                    b.HasIndex("WorkflowName_Title");

                    b.ToTable("Translation");
                });

            modelBuilder.Entity("amorphie.workflow.core.Models.FlowHeader", b =>
                {
                    b.Property<string>("Key")
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

                    b.HasKey("Key");

                    b.ToTable("FlowHeaders");
                });

            modelBuilder.Entity("amorphie.workflow.core.Models.UiForm", b =>
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

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ModifiedByBehalfOf")
                        .HasColumnType("uuid");

                    b.Property<int?>("Navigation")
                        .HasColumnType("integer");

                    b.Property<string>("StateName")
                        .HasColumnType("text");

                    b.Property<string>("TransitionName")
                        .HasColumnType("text");

                    b.Property<int?>("TypeofUiEnum")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("StateName");

                    b.HasIndex("TransitionName");

                    b.ToTable("UiForms");
                });

            modelBuilder.Entity("Instance", b =>
                {
                    b.HasOne("State", "State")
                        .WithMany()
                        .HasForeignKey("StateName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Workflow", "Workflow")
                        .WithMany()
                        .HasForeignKey("WorkflowName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZeebeMessage", "ZeebeFlow")
                        .WithMany()
                        .HasForeignKey("ZeebeFlowName");

                    b.Navigation("State");

                    b.Navigation("Workflow");

                    b.Navigation("ZeebeFlow");
                });

            modelBuilder.Entity("InstanceEvent", b =>
                {
                    b.HasOne("InstanceTransition", "InstanceTransition")
                        .WithMany()
                        .HasForeignKey("InstanceTransitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InstanceTransition");
                });

            modelBuilder.Entity("InstanceTransition", b =>
                {
                    b.HasOne("State", "FromState")
                        .WithMany()
                        .HasForeignKey("FromStateName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Instance", "Instance")
                        .WithMany()
                        .HasForeignKey("InstanceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("State", "ToState")
                        .WithMany()
                        .HasForeignKey("ToStateName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Transition", "Transition")
                        .WithMany()
                        .HasForeignKey("TransitionName");

                    b.Navigation("FromState");

                    b.Navigation("Instance");

                    b.Navigation("ToState");

                    b.Navigation("Transition");
                });

            modelBuilder.Entity("PageComponent", b =>
                {
                    b.HasOne("Page", null)
                        .WithMany("PagesComponents")
                        .HasForeignKey("PageId");
                });

            modelBuilder.Entity("State", b =>
                {
                    b.HasOne("ZeebeMessage", "OnEntryFlow")
                        .WithMany()
                        .HasForeignKey("OnEntryFlowName");

                    b.HasOne("ZeebeMessage", "OnExitFlow")
                        .WithMany()
                        .HasForeignKey("OnExitFlowName");

                    b.HasOne("Workflow", "Workflow")
                        .WithMany("States")
                        .HasForeignKey("WorkflowName");

                    b.Navigation("OnEntryFlow");

                    b.Navigation("OnExitFlow");

                    b.Navigation("Workflow");
                });

            modelBuilder.Entity("Transition", b =>
                {
                    b.HasOne("ZeebeMessage", "Flow")
                        .WithMany()
                        .HasForeignKey("FlowName");

                    b.HasOne("State", "FromState")
                        .WithMany("Transitions")
                        .HasForeignKey("FromStateName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Page", "Page")
                        .WithMany()
                        .HasForeignKey("PageId");

                    b.HasOne("State", "ToState")
                        .WithMany()
                        .HasForeignKey("ToStateName");

                    b.Navigation("Flow");

                    b.Navigation("FromState");

                    b.Navigation("Page");

                    b.Navigation("ToState");
                });

            modelBuilder.Entity("Workflow", b =>
                {
                    b.HasOne("WorkflowEntity", null)
                        .WithMany("InclusiveWorkflows")
                        .HasForeignKey("WorkflowEntityId");

                    b.HasOne("ZeebeMessage", "ZeebeFlow")
                        .WithMany()
                        .HasForeignKey("ZeebeFlowName");

                    b.Navigation("ZeebeFlow");
                });

            modelBuilder.Entity("WorkflowEntity", b =>
                {
                    b.HasOne("Workflow", "Workflow")
                        .WithMany("Entities")
                        .HasForeignKey("WorkflowName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Workflow");
                });

            modelBuilder.Entity("amorphie.core.Base.Translation", b =>
                {
                    b.HasOne("PageComponentUiModel", null)
                        .WithMany("buttonText")
                        .HasForeignKey("PageComponentUiModelId");

                    b.HasOne("Page", null)
                        .WithMany("Pages")
                        .HasForeignKey("PageId_Page");

                    b.HasOne("State", null)
                        .WithMany("Descriptions")
                        .HasForeignKey("StateName_Description");

                    b.HasOne("State", null)
                        .WithMany("PublicForms")
                        .HasForeignKey("StateName_PublicForm");

                    b.HasOne("State", null)
                        .WithMany("Titles")
                        .HasForeignKey("StateName_Title");

                    b.HasOne("Transition", null)
                        .WithMany("Forms")
                        .HasForeignKey("TransitionName_Form");

                    b.HasOne("Transition", null)
                        .WithMany("HistoryForms")
                        .HasForeignKey("TransitionName_HistoryForm");

                    b.HasOne("Transition", null)
                        .WithMany("Pages")
                        .HasForeignKey("TransitionName_Page");

                    b.HasOne("Transition", null)
                        .WithMany("Titles")
                        .HasForeignKey("TransitionName_Title");

                    b.HasOne("amorphie.workflow.core.Models.UiForm", null)
                        .WithMany("Forms")
                        .HasForeignKey("UiForm_Id");

                    b.HasOne("Workflow", null)
                        .WithMany("HistoryForms")
                        .HasForeignKey("WorkflowName_HistoryForm");

                    b.HasOne("Workflow", null)
                        .WithMany("Titles")
                        .HasForeignKey("WorkflowName_Title");
                });

            modelBuilder.Entity("amorphie.workflow.core.Models.UiForm", b =>
                {
                    b.HasOne("State", "State")
                        .WithMany("UiForms")
                        .HasForeignKey("StateName");

                    b.HasOne("Transition", "Transition")
                        .WithMany("UiForms")
                        .HasForeignKey("TransitionName");

                    b.Navigation("State");

                    b.Navigation("Transition");
                });

            modelBuilder.Entity("Page", b =>
                {
                    b.Navigation("Pages");

                    b.Navigation("PagesComponents");
                });

            modelBuilder.Entity("PageComponentUiModel", b =>
                {
                    b.Navigation("buttonText");
                });

            modelBuilder.Entity("State", b =>
                {
                    b.Navigation("Descriptions");

                    b.Navigation("PublicForms");

                    b.Navigation("Titles");

                    b.Navigation("Transitions");

                    b.Navigation("UiForms");
                });

            modelBuilder.Entity("Transition", b =>
                {
                    b.Navigation("Forms");

                    b.Navigation("HistoryForms");

                    b.Navigation("Pages");

                    b.Navigation("Titles");

                    b.Navigation("UiForms");
                });

            modelBuilder.Entity("Workflow", b =>
                {
                    b.Navigation("Entities");

                    b.Navigation("HistoryForms");

                    b.Navigation("States");

                    b.Navigation("Titles");
                });

            modelBuilder.Entity("WorkflowEntity", b =>
                {
                    b.Navigation("InclusiveWorkflows");
                });

            modelBuilder.Entity("amorphie.workflow.core.Models.UiForm", b =>
                {
                    b.Navigation("Forms");
                });
#pragma warning restore 612, 618
        }
    }
}
