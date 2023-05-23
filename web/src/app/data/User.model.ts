export interface User {
  date_of_birth: string;
  employment_date: string;
  address: string;
  mobile_number: string;
  skills: any[];
  benefits: any[];
  languages: any[];
  working_position: WorkingPosition;
  role: Role;
  user_status: UserStatus;
  vacations: any[];
  religious_holidays: any[];
  email: string;
  free_days: number;
  id: number;
  first_name: string;
  last_name: string;
}

export interface WorkingPosition {
  id: number;
  name: string;
}

export interface Role {
  id: number;
  name: string;
}

export interface UserStatus {
  id: number;
  name: string;
}
