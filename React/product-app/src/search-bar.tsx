import React from "react";
import Checkbox from "@mui/material/Checkbox";
import { FormControlLabel, Stack, TextField } from "@mui/material";

const SearchBar = () => {
  return (
    <>
      <Stack direction={"column"}>
        <TextField
          id="outlined-basic"
          label="Search for Product"
          variant="outlined"
          sx={{ width: 380 }}
        />

        <FormControlLabel
          control={<Checkbox checked={true} />}
          label="Only show product in stock"
        />
      </Stack>
    </>
  );
};

export default SearchBar;
