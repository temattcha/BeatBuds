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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Classificacao")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlaylistId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PlaylistId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("AvaliacaoPlaylist");
                });

            modelBuilder.Entity("BeatBuds.Models.Musica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Album")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("AnoLancamento")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Artista")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Musica");
                });

            modelBuilder.Entity("BeatBuds.Models.MusicaPlaylist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MusicaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlaylistId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MusicaId");

                    b.HasIndex("PlaylistId");

                    b.ToTable("MusicaPlaylist");
                });

            modelBuilder.Entity("BeatBuds.Models.Playlist", b =>
                {
                    b.Property<int>("Id")
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

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Playlist");
                });

            modelBuilder.Entity("BeatBuds.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

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
                        .WithMany("Avaliacoes")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Playlist");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("BeatBuds.Models.Musica", b =>
                {
                    b.HasOne("BeatBuds.Models.Usuario", "Usuario")
                        .WithMany("Musicas")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("BeatBuds.Models.MusicaPlaylist", b =>
                {
                    b.HasOne("BeatBuds.Models.Musica", "Musica")
                        .WithMany("Playlists")
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
                        .WithMany("Playlists")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("BeatBuds.Models.Usuario", b =>
                {
                    b.HasOne("BeatBuds.Models.Usuario", null)
                        .WithMany("Contatos")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("BeatBuds.Models.Musica", b =>
                {
                    b.Navigation("Playlists");
                });

            modelBuilder.Entity("BeatBuds.Models.Playlist", b =>
                {
                    b.Navigation("Avaliacoes");

                    b.Navigation("Musicas");
                });

            modelBuilder.Entity("BeatBuds.Models.Usuario", b =>
                {
                    b.Navigation("Avaliacoes");

                    b.Navigation("Contatos");

                    b.Navigation("Musicas");

                    b.Navigation("Playlists");
                });
#pragma warning restore 612, 618
        }
    }
}
