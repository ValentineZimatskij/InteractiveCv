// InteractiveCv.Client/src/App.tsx
//import React from 'react';
import Terminal from './components/Terminal/Terminal';
import './App.css';

function App() {
    return (
        <div className="App">
            <header className="App-header">
                <h1>Interactive CV</h1>
                <p>Исследуйте мое резюме через консоль</p>
            </header>

            <main>
                <Terminal />
            </main>
        </div>
    );
}

export default App;