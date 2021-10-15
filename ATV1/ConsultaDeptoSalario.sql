
  SELECT Departamento.Nome AS Departamento, Colaboradores.Nome AS Pessoa, Colaboradores.Salario AS Salario FROM Colaboradores INNER JOIN
  Departamento ON Departamento.Id = Colaboradores.DeptId WHERE (Concat(Colaboradores.Salario,'-',Colaboradores.DeptId))  IN 
  (SELECT Concat(MAX(Salario),'-',DeptId) as Salario From Colaboradores GROUP BY DeptId); 