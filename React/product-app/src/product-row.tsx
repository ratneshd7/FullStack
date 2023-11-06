import { TableCell, TableRow } from "@mui/material";
import * as React from "react";

const ProductRow = ({ product }) => {
  const name = product.stocked ? (
    product.name
  ) : (
    <span style={{ color: "red" }}>{product.name}</span>
  );
  return (
    <>
      <TableRow
        key={product.name}
        sx={{ "&:last-child td, &:last-child th": { border: 0 } }}
      >
        <TableCell align="right">{name}</TableCell>
        <TableCell align="right">{product.price}</TableCell>
      </TableRow>
    </>
  );
};

export default ProductRow;
