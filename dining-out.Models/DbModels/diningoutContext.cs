﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace dining_out.Models.DbModels
{
    public partial class diningoutContext : DbContext
    {
        public diningoutContext()
        {
        }

        public diningoutContext(DbContextOptions<diningoutContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BookTableAttendee> BookTableAttendees { get; set; }
        public virtual DbSet<BookTableRezervation> BookTableRezervations { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server=127.0.0.1;port=3306;uid=root;pwd=password;database=dining-out");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookTableAttendee>(entity =>
            {
                entity.ToTable("BookTableAttendee");

                entity.HasIndex(e => e.BooktableRezervationId, "BookTableAttendee_BookTableRezervation_id_fk");

                entity.HasIndex(e => e.UserId, "BookTableAttendee_User_id_fk");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BooktableRezervationId).HasColumnName("booktable_rezervation_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.BooktableRezervation)
                    .WithMany(p => p.BookTableAttendees)
                    .HasForeignKey(d => d.BooktableRezervationId)
                    .HasConstraintName("BookTableAttendee_BookTableRezervation_id_fk");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BookTableAttendees)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("BookTableAttendee_User_id_fk");
            });

            modelBuilder.Entity<BookTableRezervation>(entity =>
            {
                entity.ToTable("BookTableRezervation");

                entity.HasIndex(e => e.RestaurantId, "BookTableRezervation_Restaurant_id_fk");

                entity.HasIndex(e => e.RezervationUserId, "BookTableRezervation_User_id_fk");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AttendeeNumber).HasColumnName("attendee_number");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .HasColumnName("description");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .HasColumnName("email");

                entity.Property(e => e.NameLastname)
                    .HasMaxLength(200)
                    .HasColumnName("name_lastname");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(200)
                    .HasColumnName("phone_number");

                entity.Property(e => e.RestaurantId).HasColumnName("restaurant_id");

                entity.Property(e => e.RezervationDate)
                    .HasColumnType("date")
                    .HasColumnName("rezervation_date");

                entity.Property(e => e.RezervationStatus)
                    .HasMaxLength(100)
                    .HasColumnName("rezervation_status");

                entity.Property(e => e.RezervationTime).HasColumnName("rezervation_time");

                entity.Property(e => e.RezervationUserId).HasColumnName("rezervation_user_id");

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.BookTableRezervations)
                    .HasForeignKey(d => d.RestaurantId)
                    .HasConstraintName("BookTableRezervation_Restaurant_id_fk");

                entity.HasOne(d => d.RezervationUser)
                    .WithMany(p => p.BookTableRezervations)
                    .HasForeignKey(d => d.RezervationUserId)
                    .HasConstraintName("BookTableRezervation_User_id_fk");
            });

            modelBuilder.Entity<Restaurant>(entity =>
            {
                entity.ToTable("Restaurant");

                entity.HasIndex(e => e.UserId, "Restaurant_User_id_fk");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(300)
                    .HasColumnName("address");

                entity.Property(e => e.Capacity).HasColumnName("capacity");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .HasColumnName("city");

                entity.Property(e => e.CityId).HasColumnName("cityId");

                entity.Property(e => e.CoverImg)
                    .HasMaxLength(1000)
                    .HasColumnName("cover_img");

                entity.Property(e => e.Desc)
                    .HasMaxLength(1000)
                    .HasColumnName("desc");

                entity.Property(e => e.District)
                    .HasMaxLength(200)
                    .HasColumnName("district");

                entity.Property(e => e.DistrictId).HasColumnName("districtId");

                entity.Property(e => e.Logo)
                    .HasMaxLength(300)
                    .HasColumnName("logo");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.SystemDefinitionName)
                    .HasMaxLength(200)
                    .HasColumnName("system_definition_name");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Restaurants)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("Restaurant_User_id_fk");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(300)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .HasColumnName("password");

                entity.Property(e => e.Surname)
                    .HasMaxLength(300)
                    .HasColumnName("surname");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .HasColumnName("user_name");

                entity.Property(e => e.UserType)
                    .HasMaxLength(100)
                    .HasColumnName("user_type");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
