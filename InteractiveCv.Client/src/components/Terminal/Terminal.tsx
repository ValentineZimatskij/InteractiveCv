// InteractiveCv.Client/src/components/Terminal/Terminal.tsx
import { useState, useRef, useEffect } from 'react';
import type { FormEvent } from 'react';
import './Terminal.css';

interface CommandHistory {
    input: string;
    output: string;
}

const Terminal = () => {
    const [input, setInput] = useState('');
    const [commands, setCommands] = useState<CommandHistory[]>([]);
    const inputRef = useRef<HTMLInputElement>(null);
    const terminalRef = useRef<HTMLDivElement>(null);

    const executeCommand = (cmd: string): string => {
        const command = cmd.trim().toLowerCase();

        switch (command) {
            case 'help':
                return `Доступные команды:
help    - показать это сообщение
about   - обо мне
skills  - технические навыки
exp     - опыт работы
projects- мои проекты
edu     - образование
clear   - очистить консоль
contact - контакты`;

            case 'about':
                return `👋 Привет! Я full-stack разработчик с опытом создания веб-приложений.`;

            case 'skills':
                return `💻 Технические навыки:
• Frontend: React, TypeScript, Vue.js
• Backend: ASP.NET Core, Node.js
• Databases: PostgreSQL, MongoDB
• DevOps: Docker, GitHub Actions`;

            case 'exp':
            case 'experience':
                return `💼 Опыт работы:
• Senior Full-Stack Developer (2022-сейчас)
• Middle .NET Developer (2020-2022)`;

            case 'projects':
                return `🚀 Мои проекты:
• Interactive CV - это резюме!
• E-commerce platform
• Real-time чат приложение`;

            case 'edu':
            case 'education':
                return `🎓 Образование:
• Магистр компьютерных наук (2016-2018)
• Бакалавр программной инженерии (2012-2016)`;

            case 'contact':
                return `📧 Контакты:
• Email: developer@example.com
• GitHub: github.com/username
• LinkedIn: linkedin.com/in/username`;

            case 'clear':
                setCommands([]);
                return '';

            case '':
                return '';

            default:
                return `Команда не найдена: ${command}. Введите "help" для списка команд.`;
        }
    };

    const handleSubmit = (e: FormEvent) => {
        e.preventDefault();
        if (!input.trim()) return;

        const output = executeCommand(input);

        if (input.trim().toLowerCase() !== 'clear') {
            setCommands(prev => [...prev, {
                input: input.trim(),
                output
            }]);
        }

        setInput('');
    };

    useEffect(() => {
        inputRef.current?.focus();
    }, []);

    useEffect(() => {
        if (terminalRef.current) {
            terminalRef.current.scrollTop = terminalRef.current.scrollHeight;
        }
    }, [commands]);

    return (
        <div className="terminal">
            <div className="terminal-header">
                <div className="terminal-buttons">
                    <span className="button close"></span>
                    <span className="button minimize"></span>
                    <span className="button maximize"></span>
                </div>
                <span className="terminal-title">console — bash</span>
            </div>

            <div className="terminal-body" ref={terminalRef}>
                <div className="welcome-message">
                    🌟 Добро пожаловать в интерактивное резюме!
                    <br />Введите &quot;help&quot; для списка команд.
                </div>

                {commands.map((cmd, index) => (
                    <div key={index} className="command-block">
                        <div className="command-input-line">
                            <span className="prompt">$</span>
                            <span className="command-text">{cmd.input}</span>
                        </div>
                        {cmd.output && (
                            <div className="command-output">
                                {cmd.output}
                            </div>
                        )}
                    </div>
                ))}

                <form onSubmit={handleSubmit} className="input-line">
                    <span className="prompt">$</span>
                    <input
                        ref={inputRef}
                        type="text"
                        value={input}
                        onChange={(e) => setInput(e.target.value)}
                        className="command-input-field"
                        placeholder="Введите команду..."
                    />
                </form>
            </div>
        </div>
    );
};

export default Terminal;