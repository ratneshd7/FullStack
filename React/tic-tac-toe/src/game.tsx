import React, { useState } from "react";
import Board from "./board.tsx";

const Game = () => {
  const [isXNext, setIsXNext] = useState(true);
  const [history, setHistory] = useState([Array(9).fill(null)]);
  const [currentMove, setCurrentMove] = useState(0);
  const currentSquares = history[currentMove];

  function handlePlay(nextSquares) {
    const nextHistory = [...history.slice(0, currentMove + 1), nextSquares];
    setHistory(nextHistory);
    setCurrentMove(nextHistory.length - 1);
    setIsXNext(!isXNext);
  }

  function jumpTo(nextMove) {
    setCurrentMove(nextMove);
    setIsXNext(nextMove % 2 === 0);
  }

  return (
    <div>
      <Board isXNext={isXNext} squares={currentSquares} onPlay={handlePlay} />
      <div>
        <p>Moves</p>
        <ol>
          {history.map((squares, move) => {
            let description;
            if (move > 0) {
              description = "Go to move #" + move;
            } else {
              description = "Go to game start";
            }
            return (
              <li key={move}>
                <button onClick={() => jumpTo(move)}>{description}</button>
              </li>
            );
          })}
        </ol>
      </div>
    </div>
  );
};

export default Game;
