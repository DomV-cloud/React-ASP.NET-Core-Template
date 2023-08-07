import React from 'react';
import { BrowserRouter as Router, Routes, Route, Link } from 'react-router-dom';

const Navigation = () => {

    return (

        <div>
            <nav style={{ margin: 10 }}>
                <Link to="/home" style={{ padding: 5 }}>
                    Home
                </Link>
                <Link to="/about" style={{ padding: 5 }}>
                    About
                </Link>
            </nav>
          
        </div>

    );
};

export default Navigation;
