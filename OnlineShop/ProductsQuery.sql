select p.Name, c.Name
from products p
left join product_category_relationship pcr on p.Id = pcr.Product
left join categories c on pcr.Category = c.Id