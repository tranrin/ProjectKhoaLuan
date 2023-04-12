import * as React from 'react';
import { DemoContainer } from '@mui/x-date-pickers/internals/demo';
import { AdapterDayjs } from '@mui/x-date-pickers/AdapterDayjs';
import { LocalizationProvider } from '@mui/x-date-pickers/LocalizationProvider';
import { MobileTimePicker } from '@mui/x-date-pickers/MobileTimePicker';
import { TimeField } from '@mui/x-date-pickers/TimeField';
import { makeStyles } from '@mui/material';




export default function TimepickerView() {

  return (
    <>
       <LocalizationProvider dateAdapter={AdapterDayjs}>   
    <DemoContainer
      components={['TimeField', 'TimeField', 'TimeField']}
      sx={{ minWidth: 210 }}
    >
     <TimeField
          label="Format without meridiem"
          ampm = {false}
         // value={value}
        //  onChange={(newValue) => setValue(newValue)}
          format="HH:mm"
        />
      
    </DemoContainer>
  </LocalizationProvider>
    </>
 
  );
}