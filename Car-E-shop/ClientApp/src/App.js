import React, { Component } from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Home from '../src/components/Home'
import About from '../src/components/About'
import NoMatch from '../src/components/ErrorViews/NoMatch'

const App = () => {
    return (
         <Routes>
            <Route path="/" element={<Home />} />
            <Route path="/about" element={<About />} />
            <Route path="*" element={<NoMatch />} />

         </Routes>
       
    );
};
export default App;
