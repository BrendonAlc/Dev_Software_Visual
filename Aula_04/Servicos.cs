using System;
using System.Collections.Generic;
using System.IO;

namespace Aula_04{
    class Usuario //Classe dos usuários
    {
        static int UID = 0;
        int id;
        string username;
        string hash;

        public Usuario(string u, string p) //Construtor
        {
            id = getUID();
            SetUsername(u);
            ApplyHash(p);
        }

        static int getUID()
        {
            UID++;
            return UID;
        }

        public void ApplyHash(string password)
        {
            //TODO aplicar hash
            hash = password;
        }

        public string GetUsername(string u)
        {
            return username = u;
        }

        public string GetHash()
        {
            return hash;
        }

        public void SetUsername(string u)
        {
            
        }

        public string Serialize()
        {
            return id + "," + username + "," + hash;
        }
    }

    //System.Collection.Generic
    class UserBase
    {
        string filename;
        List<Usuario> usuarios;
        
        public UserBase(string f)
        {
            filename = f;
            usuarios = new List<Usuario>();
            LoadUsers();
        }

        void LoadUsers()
        {
            //TODO carregar usuarios do arquivo
        }

        public void AddUser(Usuario u)
        {
            usuarios.Add(u);
        }

        public void Save()
        {
            string output;

            foreach (Usuario u in usuarios)
            {
                output += u.Serialize() + "\n";
            }
            File.WriteAllText(filename, output);
        }
    }
}