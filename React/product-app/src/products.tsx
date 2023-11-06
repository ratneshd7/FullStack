import React, { useState } from "react";
import SearchBar from "./search-bar.tsx";
import { Typography } from "@mui/material";
import ProductTable from "./product-table.tsx";
import PRODUCT_LIST from "./constant.tsx";

const Product = () => {
  const [filterText, setFilterText] = useState("");
  const [inStockOnly, setInStockOnly] = useState(false);

  return (
    <>
      <Typography variant="h4" textAlign={"center"}>
        Product App
      </Typography>
      <SearchBar filterText={filterText} inStockOnly={inStockOnly}  onFilterTextChange={setFilterText}
        onInStockOnlyChange={setInStockOnly} />
      <ProductTable
        products={PRODUCT_LIST}
        filterText={filterText}
        inStockOnly={inStockOnly}
      />
    </>
  );
};

export default Product;
