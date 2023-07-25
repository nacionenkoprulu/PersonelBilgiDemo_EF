﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PersonelBilgiProject.Entities;

namespace PersonelBilgiProject.Contexts;

public partial class PersonelBilgileriDbContext : DbContext
{
    public PersonelBilgileriDbContext()
    {
    }

    public PersonelBilgileriDbContext(DbContextOptions<PersonelBilgileriDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Iletisim> Iletisim { get; set; }

    public virtual DbSet<Maas> Maas { get; set; }

    public virtual DbSet<Personel> Personel { get; set; }

    public virtual DbSet<Sehir> Sehir { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=PersonelBilgileriDB;trusted_connection=true;trustservercertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Iletisim>(entity =>
        {
            entity.Property(e => e.Adres)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.CepTelefon)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Eposta)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.EvTelefon)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.Personel).WithMany(p => p.Iletisim)
                .HasForeignKey(d => d.PersonelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Iletisim_Personel");

            entity.HasOne(d => d.Sehir).WithMany(p => p.Iletisim)
                .HasForeignKey(d => d.SehirId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Iletisim_Sehir");
        });

        modelBuilder.Entity<Maas>(entity =>
        {
            entity.Property(e => e.Ucret).HasColumnType("money");
            entity.Property(e => e.Yil)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.Personel).WithMany(p => p.Maas)
                .HasForeignKey(d => d.PersonelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Maas_Personel");
        });

        modelBuilder.Entity<Personel>(entity =>
        {
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DogumTarih).HasColumnType("date");
            entity.Property(e => e.KimlikNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Soyad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Sehir>(entity =>
        {
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
