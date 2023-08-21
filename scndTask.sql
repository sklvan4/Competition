select
    prd.Name,
    cat.Name
from Products as prd
left join ProductsToCategories as ptc on ptc.ProductId = prd.Id
left join Categories as cat on ptc.CategoryId = cat.Id