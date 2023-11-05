import React, { useState } from "react";
import Button from "@mui/material/Button";
const Square = ({ value, onSquareClick }) => {
  return (
    <Button
      variant="outlined"
      sx={{
        borderRadius: 0,
        width: 60,
        height: 40,
      }}
      onClick={onSquareClick}
    >
      {value}
    </Button>
  );
};

export default Square;
