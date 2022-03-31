-- auto-generated definition
create table product_category_relationship
(
    Product  uniqueidentifier not null
        constraint product_category_relationship_products_Id_fk
            references products
            on update cascade on delete cascade,
    Category uniqueidentifier not null
        constraint product_category_relationship_categories_Id_fk
            references categories
            on update cascade on delete cascade
)
go

create unique index product_category_relationship_Product_Category_uindex
    on product_category_relationship (Product, Category)
go