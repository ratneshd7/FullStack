import React from "react";
import SearchBar from "./search-bar.tsx";
import { Typography } from "@mui/material";

const Product = () => {
  return (
    <>
      <Typography variant="h4" textAlign={"center"}>
        Product App
      </Typography>
      <SearchBar />
    </>
  );
};

export default Product;
