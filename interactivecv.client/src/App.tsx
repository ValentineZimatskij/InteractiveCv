// InteractiveCv.Client/src/App.tsx
//import * as React from 'react';
import Terminal from './components/Terminal/Terminal';
import './App.css';

function App() {
    return (
        <div className="App">
            <header className="App-header">
                <h1>Interactive CV</h1>
                <p>Консоль</p>
            </header>

            <main>
                <Terminal />
            </main>
        </div>
    );
}

export default App;