/* Maak de tabellen en contraints aan. */

    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK34994B2841DBD2AA]') AND parent_object_id = OBJECT_ID('Genus'))
alter table Genus  drop constraint FK34994B2841DBD2AA


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK6008234915DC7AC]') AND parent_object_id = OBJECT_ID('ReefInhabitant'))
alter table ReefInhabitant  drop constraint FK6008234915DC7AC


    if exists (select * from dbo.sysobjects where id = object_id(N'Reference') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table Reference

    if exists (select * from dbo.sysobjects where id = object_id(N'Family') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table Family

    if exists (select * from dbo.sysobjects where id = object_id(N'Genus') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table Genus

    if exists (select * from dbo.sysobjects where id = object_id(N'ReefInhabitant') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table ReefInhabitant

    create table Reference (
        Id UNIQUEIDENTIFIER not null,
       Website NVARCHAR(255) null,
       Title NVARCHAR(255) null,
       Source NVARCHAR(255) null,
       primary key (Id)
    )

    create table Family (
        Id UNIQUEIDENTIFIER not null,
       Name NVARCHAR(255) null,
       Description NVARCHAR(255) null,
       primary key (Id)
    )

    create table Genus (
        Id UNIQUEIDENTIFIER not null,
       Name NVARCHAR(255) null,
       Description NVARCHAR(255) null,
       Family UNIQUEIDENTIFIER null,
       primary key (Id)
    )

    create table ReefInhabitant (
        Id UNIQUEIDENTIFIER not null,
       Name NVARCHAR(255) null,
       Species NVARCHAR(255) not null,
       Length INT null,
       Volume INT null,
       AquariumSuitability NVARCHAR(255) null,
       ReefSafety INT null,
       ReefSafetyDescription NVARCHAR(255) null,
       Temperament INT null,
       TemperamentDescription NVARCHAR(255) null,
       Hardiness INT null,
       Suitability INT null,
       Genus UNIQUEIDENTIFIER not null,
       primary key (Id)
    )

    alter table Genus 
        add constraint FK34994B2841DBD2AA 
        foreign key (Family) 
        references Family

    alter table ReefInhabitant 
        add constraint FK6008234915DC7AC 
        foreign key (Genus) 
        references Genus
