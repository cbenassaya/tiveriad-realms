using FluentValidation;
using Tiveriad.Repositories;
using Tiveriad.Realms.Core.Entities;
using System;

namespace Tiveriad.Realms.Applications.Queries.RoleQueries;
public class GetRoleByIdPreValidator : AbstractValidator<GetRoleByIdRequest>
{
    private IRepository<Role, string> _roleRepository;
    private IRepository<Module, string> _moduleRepository;
    public GetRoleByIdPreValidator(IRepository<Role, string> roleRepository, IRepository<Module, string> moduleRepository)
    {
        _roleRepository = roleRepository;
        _moduleRepository = moduleRepository;
    }
}