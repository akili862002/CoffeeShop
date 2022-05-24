SELECT SUM([order].buyer_id*[product].price)
FROM [order] INNER JOIN [product] ON [order].table_id = [product].id