import { TableCell, TableRow } from "@mui/material";
import * as React from "react";

const ProductCategoryRow = ({ category }: string) => {
  return (
    <>
      <TableRow
        key={category}
        sx={{ "&:last-child td, &:last-child th": { border: 0 } }}
      >
        <TableCell component="th" scope="row">
          {category}
        </TableCell>
      </TableRow>
    </>
  );
};

export default ProductCategoryRow;
