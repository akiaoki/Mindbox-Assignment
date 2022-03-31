-- auto-generated definition
create table products
(
    Id   uniqueidentifier not null
        constraint products_pk
            primary key,
    Name varchar(20)      not null
)
go

create unique index products_Id_uindex
    on products (Id)
go

create unique index products_Name_uindex
    on products (Name)
go

