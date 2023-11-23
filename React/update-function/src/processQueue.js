export function getFinalState(baseState, queue) {
    let finalState = baseState;
  
    for (let update of queue) {
        if (typeof update === 'function') {
          console.log("INSIDE  FUNCT  " +update)
        // Apply the updater function.
        finalState = update(finalState);
      } else {
            // Replace the next state.
            console.log(update)
        finalState = update;
      }
    }
  
    return finalState;
  }
  