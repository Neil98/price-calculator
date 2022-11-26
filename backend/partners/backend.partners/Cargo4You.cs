﻿using AutoMapper;
using backend.domain.calculation;
using backend.domain.Limits;
using backend.domain.validation;
using Range = backend.domain.Limits.Range;

namespace backend.partners
{
	public class Cargo4You : PartnerBase
	{
		public Cargo4You(IMapper mapper, IRequestValidator requestValidator, ICalculator calculator) 
			: base(
				mapper: mapper,
				requestValidator: requestValidator,
				calculator: calculator,
				weightRange: new Range(
					lowerLimit: null,
					upperLimit: new Limit(value: 20, inclusive: true)),
				volumeRange: new Range(
					lowerLimit: null,
					upperLimit: new Limit(value: 2000, inclusive: true)))
		{
		}
	}
}
