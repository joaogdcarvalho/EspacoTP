﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EspacoTP.MODEL;
using MySql.Data.MySqlClient;
using EspacoTP.UTIL;
using System.Data;

namespace EspacoTP.DAL
{
    class InstrutoresDAL
    {
        #region Query

        private const string SELECT = "uspInstrutoresBuscar";
        private const string INSERT = "uspInstrutoresIncluir";
        private const string UPDATE = "uspInstrutoresAlterar";

        private const string CONTAR_INSTRUTORES = "uspContarInstrutores";

        #endregion

        #region Methods

        public static DataTable Buscar(out string pstrMensagem, out bool pbooRetorno)
        {
            DataTable dtTable = new DataTable();
            MySqlConnection conn = ConexaoBD.CriarConexao(out pstrMensagem, out pbooRetorno);
            if (pbooRetorno)
            {
                using (conn)
                {
                    using (MySqlCommand cmd = new MySqlCommand(SELECT, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        try
                        {
                            MySqlDataAdapter dtAdapter = new MySqlDataAdapter(cmd);                            
                            dtAdapter.Fill(dtTable);
                        }
                        catch (MySqlException ex)
                        {
                            pstrMensagem = string.Format("Erro: 'Método: InstrutoresDAL.Buscar'. \n\n{0}.", ex.Message);
                            pbooRetorno = false;
                        }
                        finally
                        {
                            cmd.Connection.Close();
                        }
                    }
                }
            }
            else
            {
                conn.Close();
            }
            return dtTable;
        }

        public static int Incluir(out string pstrMensagem, out bool pbooRetorno, InstrutoresTO pInstrutor)
        {
            Int32 intResult = 0;
            MySqlConnection conn = ConexaoBD.CriarConexao(out pstrMensagem, out pbooRetorno);
            if (pbooRetorno)
            {
                using (conn)
                {
                    using (MySqlCommand cmd = new MySqlCommand(INSERT, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        try
                        {
                            cmd.Parameters.Clear();

                            cmd.Parameters.Add(new MySqlParameter("pStrNome", Convert.ToString(pInstrutor.Nome).Trim()));
                            cmd.Parameters.Add(new MySqlParameter("pStrSobrenome", Convert.ToString(pInstrutor.Sobrenome).Trim()));
                            cmd.Parameters.Add(new MySqlParameter("pStrCpf", Convert.ToString(pInstrutor.Cpf).Trim()));
                            cmd.Parameters.Add(new MySqlParameter("pBooAtivo", Convert.ToBoolean(pInstrutor.Ativo)));

                            intResult = cmd.ExecuteNonQuery();
                        }
                        catch (MySqlException ex)
                        {
                            pstrMensagem = string.Format("Erro: 'Método: InstrutoresDAL.Incluir'. \n\n{0}.", ex.Message);
                            pbooRetorno = false;
                        }
                        finally
                        {
                            cmd.Connection.Close();
                        }
                    }
                }
            }
            else
            {
                conn.Close();
            }
            return intResult;
        }

        public static int Alterar(out string pstrMensagem, out bool pbooRetorno, InstrutoresTO pInstrutor)
        {
            Int32 intResult = 0;
            MySqlConnection conn = ConexaoBD.CriarConexao(out pstrMensagem, out pbooRetorno);
            if (pbooRetorno)
            {
                using (conn)
                {
                    using (MySqlCommand cmd = new MySqlCommand(UPDATE, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        try
                        {
                            cmd.Parameters.Clear();
                            
                            cmd.Parameters.Add(new MySqlParameter("pNumIdInstrutor", Convert.ToInt32(pInstrutor.IdInstrutor)));
                            cmd.Parameters.Add(new MySqlParameter("pStrNome", Convert.ToString(pInstrutor.Nome).Trim()));
                            cmd.Parameters.Add(new MySqlParameter("pStrSobrenome", Convert.ToString(pInstrutor.Sobrenome).Trim()));
                            cmd.Parameters.Add(new MySqlParameter("pStrCpf", Convert.ToString(pInstrutor.Cpf).Trim()));
                            cmd.Parameters.Add(new MySqlParameter("pBooAtivo", Convert.ToBoolean(pInstrutor.Ativo)));

                            intResult = cmd.ExecuteNonQuery();
                        }
                        catch (MySqlException ex)
                        {
                            pstrMensagem = string.Format("Erro: 'Método: UsuariosDAL.Alterar'. \n\n{0}.", ex.Message);
                            pbooRetorno = false;
                        }
                        finally
                        {
                            cmd.Connection.Close();
                        }
                    }
                }
            }
            else
            {
                conn.Close();
            }
            return intResult;
        }

        public static int ContarInstrutores(out string pstrMensagem, out bool pbooRetorno)
        {
            int intResult = 0;
            MySqlConnection conn = ConexaoBD.CriarConexao(out pstrMensagem, out pbooRetorno);
            if (pbooRetorno)
            {
                using (conn)
                {
                    using (MySqlCommand cmd = new MySqlCommand(CONTAR_INSTRUTORES, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        try
                        {
                            intResult = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                        catch (MySqlException ex)
                        {
                            pstrMensagem = string.Format("Erro: 'Método: InstrutoresDAL.ContarInstrutores'. \n\n{0}.", ex.Message);
                            pbooRetorno = false;
                        }
                        finally
                        {
                            cmd.Connection.Close();
                        }
                    }
                }
            }
            else
            {
                conn.Close();
            }
            return intResult;
        }

        #endregion
    }
}
