﻿using System.Text.Json.Nodes;

namespace Json.Path.Expressions;

internal interface IBinaryValueOperator : IExpressionOperator
{
	JsonNode? Evaluate(JsonNode? left, JsonNode? right);
}

internal interface IExpressionOperator
{
	int Precedence { get; }
}