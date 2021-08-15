using ExemploLogin.Database;
using ExemploLogin.Models;
using ExemploLogin.Models.Exceptions;
using ExemploLogin.Views.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExemploLogin.Services
{
    public class UsuarioService
    {
        private readonly UsuarioDb _db = new UsuarioDb();

        private readonly CategoriaService _categoriaService = new CategoriaService();
        private readonly SituacaoService _situacaoService = new SituacaoService();


        /// <summary>
        /// Realiza uma busca dos usuários cadastrados, com base nos filtros informados.
        /// </summary>
        /// <returns>Retorna uma lista personalida de usuários para exibição em um grid.</returns>
        public List<UsuarioConsultaViewModel> BuscarUsuarios(string id, string nomeUsuario, string idCategoria, string idSituacao)
        {
            int? vId, vIdCategoria, vIdSituacao;

            #region Validação e Padronização dos filtros

            // ID.
            if (string.IsNullOrEmpty(id))
            {
                vId = null;
            }
            else
            {
                if (int.TryParse(id, out int intValue))
                {
                    vId = intValue;
                }
                else
                {
                    throw new ArgumentException("O Id. é inválido!");
                }
            }

            // Categoria.
            if (string.IsNullOrEmpty(idCategoria))
            {
                vIdCategoria = null;
            }
            else
            {
                if (int.TryParse(idCategoria, out int intValue))
                {
                    if (intValue == 0)
                        vIdCategoria = null;
                    else
                        vIdCategoria = intValue;
                }
                else
                {
                    throw new ArgumentException("Categoria inválida!");
                }
            }

            // Situação.
            if (string.IsNullOrEmpty(idSituacao))
            {
                vIdSituacao = null;
            }
            else
            {
                if (int.TryParse(idSituacao, out int intValue))
                {
                    if (intValue == 0)
                        vIdSituacao = null;
                    else
                        vIdSituacao = intValue;
                }
                else
                {
                    throw new ArgumentException("Situação inválida!");
                }
            }

            // Nome de Usuário.
            nomeUsuario = nomeUsuario?.Replace("\'", "")?.Replace("\"", "")?.ToUpper();

            #endregion

            var usuarios = _db.GetList(vId, nomeUsuario, vIdCategoria, vIdSituacao);
            var categorias = _categoriaService.GetCategorias();
            var situacoes = _situacaoService.GetSituacoes();

            var list = new List<UsuarioConsultaViewModel>();

            usuarios.ForEach(u =>
            {
                var obj = new UsuarioConsultaViewModel();

                obj.Id = u.Id;
                obj.NomeUsuario = u.NomeUsuario;
                obj.Categoria = categorias.FirstOrDefault(c => c.Id == u.IdCategoria)?.Descricao;
                obj.Situacao = situacoes.FirstOrDefault(c => c.Id == u.IdSituacao)?.Descricao;

                list.Add(obj);
            });

            return list;
        }

        /// <summary>
        /// Retorna um usuário com base no Id.
        /// </summary>
        public Usuario GetUsuario(int id)
        {
            return _db.Get(id);
        }

        /// <summary>
        /// Retorna todos os usuários cadastrados.
        /// </summary>
        public List<Usuario> GetUsuarios()
        {
            return _db.GetList();
        }

        /// <summary>
        /// Retorna todos os usuários ativos cadastrados.
        /// </summary>
        public List<Usuario> GetUsuariosAtivos()
        {
            return _db.GetList().Where(u => u.IdSituacao == 1).ToList();
        }

        /// <summary>
        /// Retorna o histórico de ações realizadas no cadastro do usuário passado por parâmetro.
        /// </summary>
        /// <param name="usuario">Usuário que se deseja obter o histórico.</param>
        public List<UsuarioHistorico> GetHistorico(Usuario usuario)
        {
            if (usuario == null)
                return null;

            return _db.GetHistorico(usuario.Id);
        }



        /// <summary>
        /// <para>
        /// Verifica se o nome de usuário e a senha informados,
        /// conferem com os registros na base de dados, para autenticar o Login.
        /// </para>
        /// Pode retornar um LoginException, caso alguma das informações não sejam autenticadas.
        /// </summary>
        /// <returns>Retorna os dados do usuário, caso a autenticação seja realizada com sucesso.</returns>
        public Usuario FazerLogin(string nomeUsuario, string senha)
        {
            if (string.IsNullOrWhiteSpace(nomeUsuario) || string.IsNullOrEmpty(senha))
            {
                throw new LoginException("Usuário e/ou senha não informados!");
            }

            var usuario = _db.GetByNomeUsuario(nomeUsuario.ToUpper());

            if (usuario == null)
            {
                throw new LoginException("Usuário não encontrado!");
            }

            if (usuario.Senha != senha)
            {
                throw new LoginException("Senha incorreta!");
            }

            return usuario;
        }

        /// <summary>
        /// <para>
        /// Salva um novo usuário ou atualiza as informações de um usuário já existente.
        /// </para>
        /// Pode retornar um ArgumentException, caso alguma das informações estejam inválidas.
        /// </summary>
        public void Salvar(Usuario usuario)
        {
            if (!IsValid(usuario, out string mensagem))
            {
                throw new ArgumentException(mensagem);
            }

            if (usuario.Id == 0)
            {
                _db.Insert(usuario);
            }
            else
            {
                _db.Update(usuario);
            }
        }


        /// <summary>
        /// Verifica se as informações do objeto são válidas.
        /// </summary>
        /// <param name="message">Armazena as inconsistências identificadas.</param>
        /// <returns>Retorna true se as informações forem válidas, caso contrário, retorna false.</returns>
        public bool IsValid(Usuario usuario, out string message)
        {
            message = "";

            // Nome de Usuário:
            if (string.IsNullOrWhiteSpace(usuario.NomeUsuario))
            {
                message += "O nome de usuário é obrigatório!\n";
            }
            else
            {
                // Padronização.
                usuario.NomeUsuario = usuario.NomeUsuario.Replace("\"", "").Replace("\'", "").ToUpper();

                // Verifica disponibilidade do nome.
                //var nomes = GetUsuariosAtivos().Select(u => u.NomeUsuario).ToList();
                //if (nomes.Contains(usuario.NomeUsuario))
                //{
                //    message += "Este nome de usuário já está sendo utilizado!\n";
                //}

                if (usuario.NomeUsuario.Length > _db.NomeUsuarioMaxLenght)
                {
                    message += $"O nome de usuário ultrapassou o limite de {_db.NomeUsuarioMaxLenght} caracteres.\n";
                }
            }

            // Senha:
            if (string.IsNullOrEmpty(usuario.Senha))
            {
                message += "A senha é obrigatória!\n";
            }
            else
            {
                if (usuario.Senha.Length > _db.SenhaMaxLenght)
                {
                    message += $"A senha ultrapassou o limite de {_db.NomeUsuarioMaxLenght} caracteres.\n";
                }
                if (usuario.Senha.Length < 5)
                {
                    message += $"A senha deve ter no mínimo 5 caracteres.\n";
                }
            }

            // Categoria:
            if (usuario.IdCategoria <= 0)
            {
                message += "A categoria é obrigatória!\n";
            }
            //else
            //{
            //    var listIdCategoria = _categoriaService.GetCategorias().Select(c => c.Id).ToList();
            //    if (!listIdCategoria.Contains(usuario.IdCategoria))
            //    {
            //        message += "Categoria Inválida!\n";
            //    }
            //}

            // Situação:
            if (usuario.IdSituacao <= 0)
            {
                message += "A situação é obrigatória!\n";
            }
            //else
            //{
            //    var listIdSituacoes = _situacaoService.GetSituacoes().Select(c => c.Id).ToList();
            //    if (!listIdSituacoes.Contains(usuario.IdSituacao))
            //    {
            //        message += "Situação Inválida!\n";
            //    }
            //}

            // Se não tiver nenhuma mensagem, as informações são válidas.
            return string.IsNullOrEmpty(message);
        }
    }
}
