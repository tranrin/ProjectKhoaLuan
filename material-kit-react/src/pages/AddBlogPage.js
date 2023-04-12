import React, { useState } from "react";
import { TextField, Button, Box } from "@mui/material";
import PropTypes from 'prop-types';
import Tabs from '@mui/material/Tabs';
import Tab from '@mui/material/Tab';
import Typography from '@mui/material/Typography';
import styled from "styled-components";
import  Step1  from "../components/addBlog/Step1";
import TimepickerView from "../components/input/TimepickerView"

function TabPanel(props) {
  const { children, value, index, ...other } = props;

  return (
    <div
      role="tabpanel"
      hidden={value !== index}
      id={`simple-tabpanel-${index}`}
      aria-labelledby={`simple-tab-${index}`}
      {...other}
    >
      {value === index && (
        <Box sx={{ p: 3 }}>
          <Typography>{children}</Typography>
        </Box>
      )}
    </div>
  );
}

TabPanel.propTypes = {
  children: PropTypes.node,
  index: PropTypes.number.isRequired,
  value: PropTypes.number.isRequired,
};

function a11yProps(index) {
  return {
    id: `simple-tab-${index}`,
    'aria-controls': `simple-tabpanel-${index}`,
  };
}

 function BasicTabs() {
  const [value, setValue] = React.useState(0);

  const handleChange = (event, newValue) => {
    setValue(newValue);
  };

  return (
    <Box sx={{ width: '100%' }}>
    <Centeredcontainer>
      <Box sx={{ borderBottom: 1, borderColor: 'divider'  }}>
        <Tabs value={value} onChange={handleChange} aria-label="basic tabs example">
          <Tab label="Thông tin chung" {...a11yProps(0)} sx={{paddingLeft: 5, paddingRight: 5,fontSize: 'large'}} />
          <Tab label="Nguyên liệu" {...a11yProps(1)} sx={{paddingLeft: 5, paddingRight: 5,fontSize: 'large'}} />
          <Tab label="Bước nấu" {...a11yProps(2)}  sx={{paddingLeft: 5, paddingRight: 5,fontSize: 'large'}}/>
        </Tabs>
      </Box>
      </Centeredcontainer>
      <TabPanel value={value} index={0}>
        Thông tin chung
        <Step1/>
      </TabPanel>
      <TabPanel value={value} index={1}>
        Nguyên liệu
      </TabPanel>
      <TabPanel value={value} index={2}>
        Bước nấu
      </TabPanel>
    
    </Box>


 

  );
}

const AddBlogPage = () => {
  const [title, setTitle] = useState("");
  const [content, setContent] = useState("");

  const handleTitleChange = (event) => {
    setTitle(event.target.value);
  };

  const handleContentChange = (event) => {
    setContent(event.target.value);
  };

  const handleAddBlog = () => {
    console.log(`Title: ${title}, Content: ${content}`);
    // add blog to database or send data to server
  };

  return (
    <>
    <div>
    <TimepickerView />
    </div>
      <BasicTabs>
         {/* {[<Step1/>,1,2]} */}
      </BasicTabs>
      
    </>

  );

};
const Centeredcontainer = styled.div`
  display: flex;
  justify-content: center;
  align-items: center;
  height: auto;

`;

export default AddBlogPage;
