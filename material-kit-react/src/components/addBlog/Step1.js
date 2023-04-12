import React, { useState } from "react";
import { TextField, Button, Box } from "@mui/material";


function Step1() {
  return (
    <>
      <Box sx={{ display: "flex", flexDirection: "column", gap: "1rem" }}>
      <TextField
        id="title"
        label="Tên công thức"
        variant="outlined"
        // value={title}
        // onChange={handleTitleChange}
      />
      <TextField
        id="content"
        label="Mô tả"
        multiline
        rows={4}
        variant="outlined"
        // value={content}
        // onChange={handleContentChange}
      />
      <Button variant="contained" >
        Add Blog
      </Button>
    </Box>

    </>
  )
}

export default Step1