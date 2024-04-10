﻿// <auto-generated />
using System;
using INTEXteam5.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace INTEXteam5.Migrations
{
    [DbContext(typeof(Intexteam5Context))]
    partial class Intexteam5ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("AspNetUserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("INTEXteam5.Models.AspNetRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "NormalizedName" }, "RoleNameIndex")
                        .IsUnique();

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("INTEXteam5.Models.AspNetRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "RoleId" }, "IX_AspNetRoleClaims_RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("INTEXteam5.Models.AspNetUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<int>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<int>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<int>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "NormalizedEmail" }, "EmailIndex");

                    b.HasIndex(new[] { "NormalizedUserName" }, "UserNameIndex")
                        .IsUnique();

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("INTEXteam5.Models.AspNetUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "UserId" }, "IX_AspNetUserClaims_UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("INTEXteam5.Models.AspNetUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex(new[] { "UserId" }, "IX_AspNetUserLogins_UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("INTEXteam5.Models.AspNetUserToken", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("INTEXteam5.Models.Customer", b =>
                {
                    b.Property<double?>("Age")
                        .HasColumnType("REAL")
                        .HasColumnName("age");

                    b.Property<string>("BirthDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("birth_date");

                    b.Property<string>("CountryOfResidence")
                        .HasColumnType("TEXT")
                        .HasColumnName("country_of_residence");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("customer_ID");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT")
                        .HasColumnName("first_name");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT")
                        .HasColumnName("gender");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT")
                        .HasColumnName("last_name");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("INTEXteam5.Models.LineItem", b =>
                {
                    b.Property<int?>("ProductId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("product_ID");

                    b.Property<int?>("Qty")
                        .HasColumnType("INTEGER")
                        .HasColumnName("qty");

                    b.Property<int?>("Rating")
                        .HasColumnType("INTEGER")
                        .HasColumnName("rating");

                    b.Property<int?>("TransactionId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("transaction_ID");

                    b.ToTable("LineItems");
                });

            modelBuilder.Entity("INTEXteam5.Models.Order", b =>
                {
                    b.Property<int?>("Amount")
                        .HasColumnType("INTEGER")
                        .HasColumnName("amount");

                    b.Property<string>("Bank")
                        .HasColumnType("TEXT")
                        .HasColumnName("bank");

                    b.Property<string>("CountryOfTransaction")
                        .HasColumnType("TEXT")
                        .HasColumnName("country_of_transaction");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("customer_ID");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("TEXT")
                        .HasColumnName("date");

                    b.Property<string>("DayOfWeek")
                        .HasColumnType("TEXT")
                        .HasColumnName("day_of_week");

                    b.Property<string>("EntryMode")
                        .HasColumnType("TEXT")
                        .HasColumnName("entry_mode");

                    b.Property<int?>("Fraud")
                        .HasColumnType("INTEGER")
                        .HasColumnName("fraud");

                    b.Property<string>("ShippingAddress")
                        .HasColumnType("TEXT")
                        .HasColumnName("shipping_address");

                    b.Property<int?>("Time")
                        .HasColumnType("INTEGER")
                        .HasColumnName("time");

                    b.Property<int?>("TransactionId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("transaction_ID");

                    b.Property<string>("TypeOfCard")
                        .HasColumnType("TEXT")
                        .HasColumnName("type_of_card");

                    b.Property<string>("TypeOfTransaction")
                        .HasColumnType("TEXT")
                        .HasColumnName("type_of_transaction");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("INTEXteam5.Models.Product", b =>
                {
                    b.Property<string>("Category")
                        .HasColumnType("TEXT")
                        .HasColumnName("category");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasColumnName("description");

                    b.Property<string>("ImgLink")
                        .HasColumnType("TEXT")
                        .HasColumnName("img_link");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.Property<int?>("NumParts")
                        .HasColumnType("INTEGER")
                        .HasColumnName("num_parts");

                    b.Property<int?>("Price")
                        .HasColumnType("INTEGER")
                        .HasColumnName("price");

                    b.Property<string>("PrimaryColor")
                        .HasColumnType("TEXT")
                        .HasColumnName("primary_color");

                    b.Property<int?>("ProductId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("product_ID");

                    b.Property<string>("SecondaryColor")
                        .HasColumnType("TEXT")
                        .HasColumnName("secondary_color");

                    b.Property<int?>("Year")
                        .HasColumnType("INTEGER")
                        .HasColumnName("year");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("AspNetUserRole", b =>
                {
                    b.HasOne("INTEXteam5.Models.AspNetRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("INTEXteam5.Models.AspNetUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("INTEXteam5.Models.AspNetRoleClaim", b =>
                {
                    b.HasOne("INTEXteam5.Models.AspNetRole", "Role")
                        .WithMany("AspNetRoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("INTEXteam5.Models.AspNetUserClaim", b =>
                {
                    b.HasOne("INTEXteam5.Models.AspNetUser", "User")
                        .WithMany("AspNetUserClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("INTEXteam5.Models.AspNetUserLogin", b =>
                {
                    b.HasOne("INTEXteam5.Models.AspNetUser", "User")
                        .WithMany("AspNetUserLogins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("INTEXteam5.Models.AspNetUserToken", b =>
                {
                    b.HasOne("INTEXteam5.Models.AspNetUser", "User")
                        .WithMany("AspNetUserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("INTEXteam5.Models.AspNetRole", b =>
                {
                    b.Navigation("AspNetRoleClaims");
                });

            modelBuilder.Entity("INTEXteam5.Models.AspNetUser", b =>
                {
                    b.Navigation("AspNetUserClaims");

                    b.Navigation("AspNetUserLogins");

                    b.Navigation("AspNetUserTokens");
                });
#pragma warning restore 612, 618
        }
    }
}