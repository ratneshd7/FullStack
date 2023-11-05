import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import Board from './board.tsx';

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
    <Board />
  </React.StrictMode>
);
