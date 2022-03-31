-- auto-generated definition
create table categories
(
    Id   uniqueidentifier not null
        constraint categories_pk
            primary key,
    Name varchar(20)      not null
)
go

create unique index categories_Id_uindex
    on categories (Id)
go

create unique index categories_Name_uindex
    on categories (Name)
go