import React from "react";
import Checkbox from "@mui/material/Checkbox";
import { FormControlLabel, Stack, TextField } from "@mui/material";

const SearchBar = ({
  filterText,
  inStockOnly,
  onFilterTextChange,
  onInStockOnlyChange,
}) => {
  return (
    <>
      <Stack direction={"column"}>
        <TextField
          id="outlined-basic"
          label="Search for Product"
          variant="outlined"
          sx={{ width: 380 }}
          value={filterText}
          onChange={(e) => onFilterTextChange(e.target.value)}
        />

        <FormControlLabel
          control={
            <Checkbox
              checked={inStockOnly}
              onChange={(e) => onInStockOnlyChange(e.target.checked)}
            />
          }
          label="Only show product in stock"
        />
      </Stack>
    </>
  );
};

export default SearchBar;
