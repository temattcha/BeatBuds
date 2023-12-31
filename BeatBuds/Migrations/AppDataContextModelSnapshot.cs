﻿// <auto-generated />
using System;
using BeatBuds.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BeatBuds.Migrations
{
    [DbContext(typeof(AppDataContext))]
    partial class AppDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("BeatBuds.Models.AvaliacaoPlaylist", b =>
                {
                    b.Property<int>("AvaliacaoPlaylistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Classificacao")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlaylistId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AvaliacaoPlaylistId");

                    b.HasIndex("PlaylistId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("AvaliacaoPlaylist");
                });

            modelBuilder.Entity("BeatBuds.Models.Musica", b =>
                {
                    b.Property<int>("MusicaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Album")
                        .HasColumnType("TEXT");

                    b.Property<int>("AnoLancamento")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Artista")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Titulo")
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MusicaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Musica");
                });

            modelBuilder.Entity("BeatBuds.Models.MusicaPlaylist", b =>
                {
                    b.Property<int>("MusicaPlaylistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MusicaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlaylistId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MusicaPlaylistId");

                    b.HasIndex("MusicaId");

                    b.HasIndex("PlaylistId");

                    b.ToTable("MusicaPlaylist");
                });

            modelBuilder.Entity("BeatBuds.Models.Playlist", b =>
                {
                    b.Property<int>("PlaylistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PlaylistId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Playlist");
                });

            modelBuilder.Entity("BeatBuds.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Senha")
                        .HasColumnType("TEXT");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("BeatBuds.Models.AvaliacaoPlaylist", b =>
                {
                    b.HasOne("BeatBuds.Models.Playlist", "Playlist")
                        .WithMany("Avaliacoes")
                        .HasForeignKey("PlaylistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeatBuds.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Playlist");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("BeatBuds.Models.Musica", b =>
                {
                    b.HasOne("BeatBuds.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("BeatBuds.Models.MusicaPlaylist", b =>
                {
                    b.HasOne("BeatBuds.Models.Musica", "Musica")
                        .WithMany()
                        .HasForeignKey("MusicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeatBuds.Models.Playlist", "Playlist")
                        .WithMany("Musicas")
                        .HasForeignKey("PlaylistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Musica");

                    b.Navigation("Playlist");
                });

            modelBuilder.Entity("BeatBuds.Models.Playlist", b =>
                {
                    b.HasOne("BeatBuds.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("BeatBuds.Models.Playlist", b =>
                {
                    b.Navigation("Avaliacoes");

                    b.Navigation("Musicas");
                });
#pragma warning restore 612, 618
        }
    }
}
