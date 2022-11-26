﻿using AutoMapper;
using backend.domain.calculation;
using backend.domain.Limits;
using backend.domain.validation;
using Range = backend.domain.Limits.Range;

namespace backend.partners
{
	public class ShipFaster : PartnerBase
	{
		public ShipFaster(IMapper mapper, IRequestValidator requestValidator, ICalculator calculator)
			: base(
				mapper: mapper,
				requestValidator: requestValidator,
				calculator: calculator,
				weightRange: new Range(
					lowerLimit: new Limit(value: 10, inclusive: false),
					upperLimit: new Limit(value: 30, inclusive: true)),
				volumeRange: new Range(
					lowerLimit: null,
					upperLimit: new Limit(value: 1700, inclusive: true)))
		{
		}
	}
}
