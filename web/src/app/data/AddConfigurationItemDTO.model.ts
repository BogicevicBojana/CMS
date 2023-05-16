import { ConfigurationType } from '../configuration.enum';

export class AddConfigurationItemDTO {
  constructor(public name: string, public type: ConfigurationType) {}
}
