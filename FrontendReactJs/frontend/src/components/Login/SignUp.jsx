import React, { useState } from 'react';
import axios from 'axios';
import logoLogin from '../assets/logoLogin.png';
import { Eye, EyeSlash } from "@phosphor-icons/react";
 
const SignUp = ({ onSignInClick }) => {
    const [name, setName] = useState('');
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const [error, setError] = useState('');
    const [showPassword, setShowPassword] = useState(false); // Estado para controlar visibilidade da senha
 
    const handleSubmit = async (event) => {
        event.preventDefault();
 
        try {
            const response = await axios.post('https://localhost:7266/api/User/Create', {
                imageUser: 'guigas',
                nameUser: name,
                emailUser: email,
                passwordUser: password,
                phoneUser: '(17)99999-9999',
            });
 
            if (response.status === 200) {
                alert('Usuário cadastrado com sucesso!');
            }
        } catch (error) {
            setError('Falha ao cadastrar o usuário. Verifique os dados e tente novamente.');
        }
    };
 
    return(
        <div className='flex flex-col w-3/4 min-h-screen px-12 justify-center'>
            <div className='flex justify-center mb-14'>
                <h1 className='text-4x1 text -[#2D2D2D] font-semibold'>Crie sua conta</h1>
 
            </div>
            <div className='flex text-lg'>
                <h2 className=''>
                    Ja possui uma conta?
               
                <span
                className='underline hover:cursor-pointer hover:text-red-600 px-1'
                onClick={onSignInClick}
                >
                    Clique aqui para entrar com a sua conta
                </span>
                </h2>
            </div>
            {error && <div className='text-red-500 mb-4'>{error}</div>}
        </div>
    );
};